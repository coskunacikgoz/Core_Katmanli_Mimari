using Northwind_Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace Northwind_DataAccess.Abstracts
{
    public interface IEntityRepositoryDal<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
