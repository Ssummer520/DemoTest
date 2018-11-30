using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace Demo.Interface
{
    public interface IRepository<T> where T : class
    {
        T QuerySingle(string sql, object paramPairs);
        IEnumerable<T> QueryList<T>(string sql, object paramPairs) where T : class;
        void Add(T entity);
        void AddBatch(IEnumerable<T> entitys);
        void Update(T entity);
        void Delete(T entity);
        void Delete(string Id);
        void Delete(int Id);
        void Delete(Guid Id);
        T Get(string Id);
        T Get(Guid Id);
        T Get(int Id);
        T Get(T entity);
        //T Get(Expression<Func<T, bool>> func);
        IEnumerable<T> GetAll();

        int Execute(string sql, dynamic paramPairs = null);
        long Count(string sql, dynamic paramPairs = null);
        //IEnumerable<T> GetList(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> order = null);
        //Tuple<int, IEnumerable<T>> GetPage(Page page, Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> order = null);
        //long Count(Expression<Func<T, bool>> where = null);
    }
}
