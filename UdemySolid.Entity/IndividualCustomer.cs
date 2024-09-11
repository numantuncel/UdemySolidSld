using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemySolid.Entity
{
    public class IndividualCustomer:Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int TcKimlik { get; set; }
    }
}
// luskov prensipleri; bir sınıf başka bir sınıfın alt sınıfı ise o sınıfa ait nesneleri taşımalı 

// iki tane sınıf ise ikiye bölünebili  ne kadar çok olursa olsun bölünebilir fakat boşta nesne kalmamalı