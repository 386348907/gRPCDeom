using FirstServer.Data;
using FirstServer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace FirstServer.Handles
{
    public class HMarkData
    {


        private string GetBLCodeSql = "SELECT "
     + "mx.SAPFZFL as fzfl,jg.ecode AS jgecode,"
     + "      fl.ecode AS flecode,"
     + "      gf.ecode AS gfecode,"
     + "      fl.ename AS flename,"
     + "      gy.tranmemo AS gytranmemo,"
     + "      dd.RCkhdh,"
     + "      jg.ksjg"
     + " FROM cnbl.t_scddhxppjgpzgy gy"
     + " INNER JOIN cnbl.t_scddhxppjg jg"
     + "   ON jg.scddhxppjgid = gy.scddhxppjgid"
     + " INNER JOIN cnbl.t_scddpzmx mx"
     + "   ON mx.scddpzmxid = jg.scddpzmxid"
     + " INNER JOIN cnbl.t_scdd dd"
     + "   ON dd.scddid = mx.scddid"
     + " INNER JOIN cnbl.c_gyfl fl"
     + "   ON fl.gyflid = gy.gyflid"
     + " INNER JOIN cnbl.c_gyflsjxx gf"
     + "   ON gy.gyflsjxxid = gf.gyflsjxxid"
     + " WHERE(gy.tranmemo is not null or gf.ecode in ('57S2', '91C8'))"
     + "  and dd.ecode = '{0}'";

        /// <summary>
        /// 处理洗标数据
        /// </summary>
        /// <returns></returns>
        public string HandlerData(string SCZSBH, Data.FirstServerDbcontext firstServerDbcontext, string BLLink)
        {

            try
            {

                var DATList = firstServerDbcontext.DAT_Production.Where(T => T.SCZSBH == SCZSBH).ToList();

                foreach (var item in DATList)
                {

                    string SCGGDH = item.SCGGDH;


                    DataSet dszdynr = new DataSet();

                    var removeList = firstServerDbcontext.BLZDYNR.Where(T => T.scggdh == SCGGDH).ToList();

                    //如果数据库中有数据  则直接删除
                    if (removeList.Count > 0)
                    {
                        firstServerDbcontext.BLZDYNR.RemoveRange();
                        firstServerDbcontext.SaveChanges();
                    }

                    int BLCodeCount = 0;

                    GetBLCodeSql = string.Format(GetBLCodeSql, SCGGDH);


                    ConnectionConfig LinkConfig = new ConnectionConfig();
                    LinkConfig.ConnectionString = BLLink;

                    LinkConfig.IsAutoCloseConnection = true;//是否自动释放数据库，设为true我们不需要close或者Using的操作，

                    LinkConfig.InitKeyType = InitKeyType.Attribute;

                    LinkConfig.DbType = SqlSugar.DbType.Oracle;
                    List<BLZDYNR> BLCODEList = new List<BLZDYNR>();
                    using (var BLDB = new SqlSugarClient(LinkConfig))
                    {

                        BLCODEList = BLDB.SqlQueryable<BLZDYNR>(GetBLCodeSql).ToList();

                    }

                    foreach (var GYItem in BLCODEList)
                    {
                        GYItem.scggdh = SCGGDH;
                    }


                    if (BLCODEList.Count > 0)
                    {

                        firstServerDbcontext.BLZDYNR.AddRange(BLCODEList);

                        BLCodeCount += firstServerDbcontext.SaveChanges();
                    }


                    Tuple<string, string> tuple = new Tuple<string, string>("获取BL工艺代码并处理数据", $"导入成功，共导入{BLCodeCount}行工艺代码!");

                    #region 处理数据

                    SqlParameter[] Param ={
                        new SqlParameter("@ID", SqlDbType.VarChar),
                         new SqlParameter("@cRESULT", SqlDbType.VarChar
                         )
                    };

                    Param[0].Value = item.ID;

                    Param[1].Direction = ParameterDirection.Output;

                    ExecuteNonQueryAsync(firstServerDbcontext, "P_MarkPrint_ProductionNEW", Param);
 
                    if (item.SCYSPD.Substring(0, 3) == "ASR")
                    {

                        var datobj = item;

                        var xbobj = ASRChuLi(datobj, firstServerDbcontext);

                        if (xbobj != null)
                        {

                            datobj.PrntXBModelCode = xbobj.XBMODEL;

                            firstServerDbcontext.DAT_Production.Update(datobj);

                            firstServerDbcontext.SaveChanges();


                        }
                    }

                    #endregion

                    #region 判断是否是ASR订单  如果是   引入 D_ASRRool表的洗标分配逻辑

                    #endregion

                }

                return "success";

            }
            catch (Exception ex)
            {

                //Core.XinXiJilu.JiLuRiZhi(SCZSBH, "获取BL工艺代码并处理数据", -1, ex.Message);

                return "error:" + ex.Message;

            }

        }


        /// <summary>
        /// 单独处理ASR订单
        /// </summary>
        public static D_ASRRool ASRChuLi(DAT_Production datps, Data.FirstServerDbcontext firstServerDbcontext)
        {

            try
            {
                List<D_ASRRool> ASRGZ = firstServerDbcontext.D_ASRRool.Where(T => T.IsDeleted == 0).ToList();

                List<D_ASRRool> Mz = new List<D_ASRRool>();
                foreach (var ASRitem in ASRGZ)
                {

                    if (datps.SCYSPD.Substring(0, ASRitem.KCount) == ASRitem.KHJC && datps.WPSXLB == ASRitem.PinLei.Trim())
                    {

                        Mz.Add(ASRitem);
 
                    }
 
                }

                var jz = Mz.OrderByDescending(O => O.YouXianJi).First();
 
                return jz;
                
            }
            catch (Exception ex)
            {

                //new Core.JiLuException(datp.SCYSPD, "处理ASR", -100, ex.Message);

                return null;
            }

        }




        /// <summary>
        /// 异步执行带有参数的存储过程方法  增删改操作以及返回带有输出的参数
        /// </summary>
        /// <param name="db"></param>
        /// <param name="sql"></param>
        /// <param name="sqlParams"></param>
        /// <returns></returns>
        public async static Task<int> ExecuteNonQueryAsync(FirstServerDbcontext db, string sql, SqlParameter[] sqlParams)
        {
            int numint;
            var connection = db.Database.GetDbConnection();
            using (var cmd = connection.CreateCommand())
            {
                await db.Database.OpenConnectionAsync();
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddRange(sqlParams);
                numint = await cmd.ExecuteNonQueryAsync();
            }

            return numint;
        }
 
    }
}
