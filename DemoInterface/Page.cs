using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoCore
{
    public class Page
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public Page()
        {
            PageIndex = 1;
            PageSize = 10;
        }

    }
}
