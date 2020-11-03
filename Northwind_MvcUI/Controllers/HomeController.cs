using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind_Business.Abstracts;
using Northwind_Entities.Concretes;
using Northwind_MvcUI.Models.ViewModels;

namespace Northwind_MvcUI.Controllers
{
    public class HomeController : Controller
    {
        IProductService _productManager;
        ICategoryService _categoryManager;

        public HomeController(IProductService productService,ICategoryService categoryService)
        {
            _productManager = productService;
            _categoryManager = categoryService;
        }

        [HttpGet]
        public IActionResult ListMyProducts()
        {
            ListProductsViewModel model = new ListProductsViewModel
            {
                Products = _productManager.GetProducts()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult AddMyProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMyProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _productManager.AddProduct(product);

            TempData["message"] = "Veri eklendi";

            return RedirectToAction("ListMyProducts");
        }

        [HttpGet]
        public IActionResult UpdateMyProduct(int id)
        {
            return View(id);
        }

        [HttpPost]
        public IActionResult UpdateMyProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View(product.ProductID);
            }

            _productManager.UpdateProduct(product);

            TempData["message"] = "Veri guncellendi";

            return RedirectToAction("ListMyProducts");
        }

        [HttpGet]
        public IActionResult DeleteMyProduct(int id)
        {
            _productManager.DeleteProduct(id);

            TempData["message"] = "Veri silindi";

            return RedirectToAction("ListMyProducts");
        }
    }
}