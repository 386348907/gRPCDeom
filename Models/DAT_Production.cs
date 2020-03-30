using System;
using System.Linq;
using System.Text;

namespace FirstServer.Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class DAT_Production
    {
        public DAT_Production()
        {


        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>  
 
        public int ID { get; set; }

        /// <summary>
        /// Desc:计划编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCZSBH { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCZSXH { get; set; }

        /// <summary>
        /// Desc:计划日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? SCXDRQ { get; set; }

        /// <summary>
        /// Desc:裁剪交期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? SCCJJQ { get; set; }

        /// <summary>
        /// Desc:缝制交期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? SCFZJQ { get; set; }

        /// <summary>
        /// Desc:整烫交期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? SCZTJQ { get; set; }

        /// <summary>
        /// Desc:包装交期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? SCBZJQ { get; set; }

        /// <summary>
        /// Desc:生产交期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? SCJHRQ { get; set; }

        /// <summary>
        /// Desc:生产厂
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCGCDM { get; set; }

        /// <summary>
        /// Desc:预订单号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCHTBH { get; set; }

        /// <summary>
        /// Desc:预订单序号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? SCHTXH { get; set; }

        /// <summary>
        /// Desc:系统订单号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCGGDH { get; set; }

        /// <summary>
        /// Desc:序号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? SCGGXH { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCZSBZ { get; set; }

        /// <summary>
        /// Desc:款式号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string XTWPKS { get; set; }

        /// <summary>
        /// Desc:面料号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string XTWPYS { get; set; }

        /// <summary>
        /// Desc:尺码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string XTXMDM { get; set; }

        /// <summary>
        /// Desc:计划数量
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? SCZSSL { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? SCZSSLCY { get; set; }

        /// <summary>
        /// Desc:计划批号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCZSPH { get; set; }

        /// <summary>
        /// Desc:签单日期
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? SCQDRQ { get; set; }

        /// <summary>
        /// Desc:门店号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string XTBMDM { get; set; }

        /// <summary>
        /// Desc:门店名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string XTBMMC { get; set; }

        /// <summary>
        /// Desc:客户代码
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string XTWLDM { get; set; }

        /// <summary>
        /// Desc:客户名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string XTWLMC { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string RCKHDDHM { get; set; }

        /// <summary>
        /// Desc:客户订单号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string KHDDHM { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public byte[] QREWM { get; set; }

        /// <summary>
        /// Desc:定制部门
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string KHBMDM { get; set; }

        /// <summary>
        /// Desc:定制部门
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string KHBMMC { get; set; }

        /// <summary>
        /// Desc:定制人名
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCKHXM { get; set; }

        /// <summary>
        /// Desc:客户/款式性别
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCKHXB { get; set; }

        /// <summary>
        /// Desc:原始凭单
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCYSPD { get; set; }

        /// <summary>
        /// Desc:客户款式
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCKGKS { get; set; }

        /// <summary>
        /// Desc:客户面料
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCKGML { get; set; }

        /// <summary>
        /// Desc:产品类别
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string WPSXLB { get; set; }

        /// <summary>
        /// Desc:产品名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string XTWPMC { get; set; }

        /// <summary>
        /// Desc:设计编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string XTSJBH { get; set; }

        /// <summary>
        /// Desc:销售单价
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string WPXSDJ { get; set; }

        /// <summary>
        /// Desc:计价单位
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string KCJJDW { get; set; }

        /// <summary>
        /// Desc:国标号型
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SIZECODE { get; set; }

        /// <summary>
        /// Desc:面料号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string FabricNo { get; set; }

        /// <summary>
        /// Desc:面料成分
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string FComposition { get; set; }

        /// <summary>
        /// Desc:里料号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string LiningNo { get; set; }

        /// <summary>
        /// Desc:里料成分
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string LComposition { get; set; }

        /// <summary>
        /// Desc:袖里料
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SleeveLiningNo { get; set; }

        /// <summary>
        /// Desc:袖里成分
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SLComposition { get; set; }

        /// <summary>
        /// Desc:规格工艺
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PRDTSPEC { get; set; }

        /// <summary>
        /// Desc:MDT定制要求
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PRDTSPEC1 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PRDTSPEC2 { get; set; }

        /// <summary>
        /// Desc:生产标准
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string MANUSTD { get; set; }

        /// <summary>
        /// Desc:产品等级
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PRDTLevel { get; set; }

        /// <summary>
        /// Desc:技术标准
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string TECHCode { get; set; }

        /// <summary>
        /// Desc:技术类型
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string TECHLevel { get; set; }

        /// <summary>
        /// Desc:条码号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PrdtBarCode { get; set; }

        /// <summary>
        /// Desc:检验号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CheckNo { get; set; }

        /// <summary>
        /// Desc:打印洗标
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool? PrntXB { get; set; }

        /// <summary>
        /// Desc:洗标模板
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PrntXBModelCode { get; set; }

        /// <summary>
        /// Desc:洗标张数
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public int? PrntXBCount { get; set; }

        /// <summary>
        /// Desc:打印吊牌
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool? PrntDP { get; set; }

        /// <summary>
        /// Desc:吊牌模板
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PrntDPModelCode { get; set; }

        /// <summary>
        /// Desc:吊牌张数
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public int? PrntDPCount { get; set; }

        /// <summary>
        /// Desc:打印盒贴
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool? PrntBZ { get; set; }

        /// <summary>
        /// Desc:盒贴模板
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PrntBZModelCode { get; set; }

        /// <summary>
        /// Desc:盒贴张数
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public int? PrntBZCount { get; set; }

        /// <summary>
        /// Desc:打印盒贴
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool? PrntFB { get; set; }

        /// <summary>
        /// Desc:盒贴模板
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string PrntFBModelCode { get; set; }

        /// <summary>
        /// Desc:盒贴张数
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public int? PrntFBCount { get; set; }

        /// <summary>
        /// Desc:缝制线号（含珠边）
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCFZXH { get; set; }

        /// <summary>
        /// Desc:锁眼线号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCSYXH { get; set; }

        /// <summary>
        /// Desc:生产纽扣编号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCNKBH { get; set; }

        /// <summary>
        /// Desc:生产工艺要求
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCGYYQ { get; set; }

        /// <summary>
        /// Desc:珠边线号
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCZBXH { get; set; }

        /// <summary>
        /// Desc:是否计划内
        /// Default:1
        /// Nullable:True
        /// </summary>           
        public bool? IsPlan { get; set; }

        /// <summary>
        /// Desc:可删除
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public bool? Deleted { get; set; }

        /// <summary>
        /// Desc:状态(0新1已处理C暂停S撤单)
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public string Status { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string bz1 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string bz2 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string bz3 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string bz4 { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string DesignNo { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string SCGCDMREAL { get; set; }

        /// <summary>
        /// Desc:
        /// Default:0
        /// Nullable:True
        /// </summary>           
        public int? TRANSSTATUS { get; set; }

        /// <summary>
        ///阻止打印
        /// </summary>
        public int PreventPrinting { get; set; }

    }
}
