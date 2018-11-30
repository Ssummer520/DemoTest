using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCore
{
    public class declare_continueedu_formal_detail
    {


        public int? autoid { get; set; }
        /// <summary>
        /// 主表主键
        /// </summary>
        public int masterid { get; set; }


        public string educationstage { get; set; }

        public DateTime? entrancedate { get; set; }

        public DateTime? expireddate { get; set; }


        public string note { get; set; }
    }
}
