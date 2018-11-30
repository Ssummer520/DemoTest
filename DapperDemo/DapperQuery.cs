using Demo.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using Dapper;
using Dapper.Contrib;
using DemoCore;


namespace Demo.Data.Dapper
{
    public class DapperQuery : IQuery
    {
        protected IDbConnection Conn { get; private set; }

        public DapperQuery()
        {
            Conn = DbConnectionFactory.CreateDbConnection();
        }

        public void SetDbConnection(IDbConnection conn)
        {
            Conn = conn;
        }

        public T QuerySingle<T>(string sql, object paramPairs) where T : class
        {
            return Conn.Query<T>(sql, paramPairs).SingleOrDefault();
        }

        public IEnumerable<T> QueryList<T>(string sql, object paramPairs) where T : class
        {
            return Conn.Query<T>(sql, paramPairs);
        }

        /// <summary>自动分页，必须带上row_number() over({0}) RowNumber</summary>
        public Tuple<int, IEnumerable<T>> GetPage<T>(Page page, string sql, object paramPairs = null) where T : class
        {
            //var multi = Conn.GetPage<T>(page.PageIndex, page.PageSize, sql, paramPairs);
            //var count = multi.Read<int>().Single();
            //var results = multi.Read<T>();
            throw new NotImplementedException();
        }
        // 需自己实现分页语句
        public Tuple<int, IEnumerable<T>> GetPage<T>(string sql, object paramPairs = null) where T : class
        {
            //var multi = Conn.GetGridReader<T>(sql, paramPairs);
            //var count = multi.Read<int>().Single();
            //var results = multi.Read<T>();
            //return new Tuple<int, IEnumerable<T>>(count, results);
            throw new NotImplementedException();
        }


        public int Execute(string sql, object paramPairs = null)
        {
            return Conn.Execute(sql, paramPairs);
        }

        public long Count(string sql, object paramPairs = null)
        {
            return Conn.Query<long>(sql, paramPairs).SingleOrDefault();
        }
    }
}