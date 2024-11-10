using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext : DbContext // Veri tabanımıza yansıayacak sınıfları buraya yazıyoruz
    {
        public DbSet<Category> Categories { get; set; } // sql e yansıyacak tablo categories // c# da kullanılacak category
        public DbSet<Product> Products { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Admin> Admins { get; set; }
    }
}
