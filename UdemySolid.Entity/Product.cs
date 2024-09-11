using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemySolid.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; } // ürün açıklaması

        public string ImagePath { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public double Price { get; set; }

        public double Tax { get; set; }


    }
}
