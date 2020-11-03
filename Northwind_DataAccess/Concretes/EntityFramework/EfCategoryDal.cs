using Northwind_DataAccess.Abstracts;
using Northwind_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_DataAccess.Concretes.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryDal<Category,NorthwindContext>,ICategoryDal
    {

    }
}
