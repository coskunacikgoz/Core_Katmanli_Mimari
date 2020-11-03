using Northwind_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind_MvcUI.Models.ViewModels
{
    public class ProductManiViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
        public string ButtonName { get; set; }
    }
}
