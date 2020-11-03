using Northwind_Business.Abstracts;
using Northwind_DataAccess.Abstracts;
using Northwind_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_Business.Concretes.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void AddProduct(Product product)
        {
            _productDal.Add(product);
        }

        public void DeleteProduct(int id)
        {
            _productDal.Delete(new Product { ProductID = id });
        }

        public Product GetProduct(int id)
        {
            return _productDal.Get(x => x.ProductID == id);
        }

        public List<Product> GetProducts()
        {
            return _productDal.GetProductsByCategoryName();
        }

        public void UpdateProduct(Product product)
        {
            _productDal.Update(product);
        }
    }
}
