using System;

namespace Demo520.Core
{
    /// <summary>
    /// 系统日志表
    /// </summary>
    public class SystemLog
    {
        public int autoid { get; set; }

        public string usercode { get; set; }

        public string action { get; set; }

        public string url { get; set; }


        public string ip { get; set; }

        public DateTime? logTime { get; set; }

        public string clienttype { get; set; }

        public string remark { get; set; }

        public string macaddress { get; set; }
    }
}
