using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoInterface
{
    public interface IUnitOfWork<T> where T : class
    {
        void RegisterAdd(T entity, Action callback);
        void RegisterUpdate(T entity, Action callback);
        void RegisterDelete(T entity, Action callback);
        void Commit();
    }
}
