using DemoCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo.Interface
{
    public interface IQuery
    {
        T QuerySingle<T>(string sql, object paramPairs) where T : class;
        IEnumerable<T> QueryList<T>(string sql, object paramPairs) where T : class;

        /// <summary>必须带上row_number() over({0}) RowNumber</summary>
        Tuple<int, IEnumerable<T>> GetPage<T>(Page page, string sql, dynamic paramPairs = null) where T : class;

        Tuple<int, IEnumerable<T>> GetPage<T>(string sql, object paramPairs = null) where T : class;
        int Execute(string sql, dynamic paramPairs = null);
        long Count(string sql, dynamic paramPairs = null);
    }
}
