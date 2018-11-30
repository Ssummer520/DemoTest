using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCore
{
    /// <summary>
    /// 员工抵扣类型
    /// </summary>
    public class employee_deduction_type
    {


        public string usercode { get; set; }
        /// <summary>
        /// 抵扣类型(0-按年,1-按月)
        /// </summary>
        public int childrenedu_type { get; set; }

        public int childrenedu_effective_month { get; set; }
        /// <summary>
        /// 抵扣类型(0-按年,1-按月)
        /// </summary>
        public int continueedu_type { get; set; }

        public int continueedu_effective_month { get; set; }
        /// <summary>
        /// 抵扣类型(0-按年,1-按月)
        /// </summary>
        public int seriousillmed_type { get; set; }

        public int seriousillmed_effective_month { get; set; }
        /// <summary>
        /// 抵扣类型(0-按年,1-按月)
        /// </summary>
        public int houseloan_type { get; set; }

        public int houseloan_effective_month { get; set; }
        /// <summary>
        /// 抵扣类型(0-按年,1-按月)
        /// </summary>
        public int houserent_type { get; set; }

        public int houserent_effective_month { get; set; }
        /// <summary>
        /// 抵扣类型(0-按年,1-按月)
        /// </summary>
        public int elderlysp_type { get; set; }

        public int elderlysp_effective_month { get; set; }
    }
}
