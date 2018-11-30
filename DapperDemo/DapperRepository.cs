

using Demo.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using DapperExtensions;
using Dapper;

namespace Demo.Data.Dapper
{
    public class DapperRepository<T> :IRepository<T> where T:class
    {
        protected IDbConnection Conn { get; private set; }

        public DapperRepository()
        {
            Conn = DbConnectionFactory.CreateDbConnection();
            

        }
        public void SetDbConnection(IDbConnection conn)
        {
            Conn = conn;
        }

        public void Add(T entity)
        {
            var a= Conn.Insert<T>(entity);


        }

        public void AddBatch(IEnumerable<T> entitys)
        {
            foreach (T entity in entitys)
            {
                Add(entity);
            }
        }

        public void Update(T entity)
        {
            Conn.Update(entity);
        }

        public void Delete(T entity)
        {
            Conn.Delete(entity);
        }

        public void Delete(string Id)
        {
            var entity = Get(Id);
            if (entity == null)
                return;
            Delete(entity);
        }

        public void Delete(int Id)
        {
            var entity = Get(Id);
            if (entity == null) return;

            Delete(entity);
        }

        public void Delete(Guid Id)
        {
            var entity = Get(Id);
            if (entity == null) return;

            Delete(entity);
        }

        public T Get(T entity)
        {
            return Conn.Get<T>(entity);
        }

        public T Get(Guid Id)
        {
            return Conn.Get<T>(Id);
        }

        public T Get(string Id)
        {
            return Conn.Get<T>(Id);
        }

        public T Get(int Id)
        {
            return Conn.Get<T>(Id);
        }

        //public T Get(Expression<Func<T, bool>> func)
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<T> GetAll()
        {
            return Conn.GetList<T>();
        }
        /// <summary>
        /// 单表多表返回次数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paramPairs"></param>
        /// <returns></returns>
        public int Execute(string sql, object paramPairs = null)
        {
            return Conn.Execute(sql, paramPairs);
        }
        /// <summary>
        /// 多表删选
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paramPairs"></param>
        /// <returns></returns>
        public long Count(string sql, object paramPairs = null)
        {
            return Conn.Query<long>(sql, paramPairs).SingleOrDefault();
        }
        //public IEnumerable<T> GetList(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> order = null)
        //{

        //    return Conn.GetList<T>();
        //}

        //public Tuple<int, IEnumerable<T>> GetPage(Page page, Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> order = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public long Count(Expression<Func<T, bool>> where = null)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
