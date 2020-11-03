using Northwind_Business.Abstracts;
using Northwind_DataAccess.Abstracts;
using Northwind_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_Business.Concretes.Managers
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetCategories()
        {
            return _categoryDal.GetAll();
        }
    }
}
