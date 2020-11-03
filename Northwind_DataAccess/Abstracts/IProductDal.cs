using Northwind_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace Northwind_DataAccess.Abstracts
{
    public interface IProductDal:IEntityRepositoryDal<Product>
    {
        List<Product> GetProductsByCategoryName(Expression<Func<Product, bool>> filter = null);
    }
}
