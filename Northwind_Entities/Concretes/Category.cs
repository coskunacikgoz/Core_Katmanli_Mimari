using Northwind_Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_Entities.Concretes
{
    public class Category:IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
