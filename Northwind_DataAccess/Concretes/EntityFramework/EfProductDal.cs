using Microsoft.EntityFrameworkCore;
using Northwind_DataAccess.Abstracts;
using Northwind_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Northwind_DataAccess.Concretes.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryDal<Product, NorthwindContext>, IProductDal
    {
        public List<Product> GetProductsByCategoryName(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                if (filter == null)
                {
                    return db.Set<Product>().Include("Category").ToList();
                }
                else
                {
                    return db.Set<Product>().Include("Category").Where(filter).ToList();
                }
            }
        }
    }
}
