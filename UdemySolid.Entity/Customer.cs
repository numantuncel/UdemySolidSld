using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemySolid.Entity
{
    public class Customer
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int AdressId {  get; set; }

        public CustomerAdress Adress { get; set; }

        public virtual List<Basket> baskets { get; set; }

        public Customer()
        {
            baskets = new List<Basket>();
        }

    }
}
// burada luskova göre içi dolu olmayan veri olmamalı

// bir sınıf başka bir sınıfdan türediğinde kullanılmayan nesne kalmamalı