using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FirstServer.Models
{
   public class D_ASRRool
    {
        [SqlSugar.SugarColumn(IsIdentity =true,IsPrimaryKey =true)]
        public int ID { get; set; }

        public string KHJC { get; set; }

        public string XBMODEL { get; set; }

        public string DPMODEL { get; set; }

        public string BZMODEL { get; set; }

        public int YouXianJi  { get; set; }

        public int KCount { get; set; }
        public string  PinLei { get; set; }



        public int IsDeleted { get; set; }

        public DateTime? CreateTime { get; set; }

    }
}
