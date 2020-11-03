using Northwind_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_Business.Abstracts
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
