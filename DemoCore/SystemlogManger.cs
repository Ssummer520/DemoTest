using DemoCore;
using Demo.Data.Dapper;
using Demo520.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo.Core
{
    public class SystemlogManger: DapperRepository<declare_continueedu_formal_detail>
    {

        public void Test()
        {
            declare_continueedu_formal_detail config =new declare_continueedu_formal_detail();
            {
                config.masterid = 2;
                //config.usercode = "333133";
                //config.seriousillmed_type = 11111;
                //config.seriousillmed_effective_month = 11111;
                //config.houserent_type = 11111;
                //config.houserent_effective_month = 11111;
                //config.houseloan_type = 11111;
                //config.houseloan_effective_month = 11111;
                //config.elderlysp_type = 11111;
                //config.elderlysp_effective_month = 11111;
                //config.continueedu_type = 11111;
                //config.continueedu_effective_month = 11111;
                //config.childrenedu_type = 11111;
                //config.childrenedu_effective_month = 11111;
               


            }


            this.Add(config);
            return;
        }
    }
}
