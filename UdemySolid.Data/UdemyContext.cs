using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemySolid.Entity;

namespace UdemySolid.Data
{
    public class UdemyContext:DbContext
    {
        public UdemyContext() : base("name=DbContextUdemy")
        {

        }
        public virtual DbSet<Basket> Baskets { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<CustomerRepository> Customers { get; set; }
    }

}

//Burada, base ifadesiyle üst sınıf olan DbContext'in yapıcı metodu çağrılarak,
//veritabanı bağlantısı için gerekli yapılandırmalar yapılır.