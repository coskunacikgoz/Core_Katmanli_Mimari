using Microsoft.EntityFrameworkCore;
using Northwind_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind_DataAccess.Concretes.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string ogrenciBilgisayari = "Server=.;Database=Northwind;UID=sa;PWD=123";

            string benimBilgisayarim = @"Server=DESKTOP-0A9OG2K\SQLEXPRESS01;Database=Northwind;Integrated Security=true";

            optionsBuilder.UseSqlServer(connectionString: benimBilgisayarim);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
