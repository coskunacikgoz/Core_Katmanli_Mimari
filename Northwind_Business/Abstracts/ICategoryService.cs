using Northwind_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_Business.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
