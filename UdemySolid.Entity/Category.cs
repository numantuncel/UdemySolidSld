using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemySolid.Entity
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }

        public virtual List<Product> Products { get; set; }// oluştuğunda null olarak dönmemsi için

        public Category()// construct // Category çağrıldığında Products list oluşur
        {
            Products = new List<Product>();
        }

    }
}
