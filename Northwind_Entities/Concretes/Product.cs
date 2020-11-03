using Northwind_Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_Entities.Concretes
{
    public class Product:IEntity
    {
        public int ProductID { get; set; }
        public int? CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        public virtual Category Category { get; set; }
    }
}
