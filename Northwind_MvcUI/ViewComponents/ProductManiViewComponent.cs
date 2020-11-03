using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Northwind_Business.Abstracts;
using Northwind_MvcUI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind_MvcUI.ViewComponents
{
    public class ProductManiViewComponent:ViewComponent
    {
        IProductService _productManager;
        ICategoryService _categoryManager;

        public ProductManiViewComponent(IProductService productService, ICategoryService categoryService)
        {
            _productManager = productService;
            _categoryManager = categoryService;
        }

        public ViewViewComponentResult Invoke(int id = 0)
        {
            ProductManiViewModel model = new ProductManiViewModel();
            model.Categories = _categoryManager.GetCategories();

            if (id == 0)
            {
                model.Product = new Northwind_Entities.Concretes.Product();
                model.ButtonName = "Add Product";
            }
            else
            {
                model.Product = _productManager.GetProduct(id);
                model.ButtonName = "Update Product";
            }

            return View(model);
        }
    }
}
