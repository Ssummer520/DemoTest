using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DapperExtensions.Mapper;
using Demo520.Core;

namespace DemoCore
{
    public class employee_deduction_typeMapper : ClassMapper<employee_deduction_type>
    {
        public employee_deduction_typeMapper()
        {
            base.Table("employee_deduction_type");

            //Map(f => f.usercode).Key(KeyType.Assigned);//设置主键  (如果主键名称不包含字母“ID”，请设置)           
            AutoMap();
        }
    }
}
