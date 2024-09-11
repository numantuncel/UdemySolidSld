using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemySolid.Entity
{
    public class CustomerAdress
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string PostalCode { get; set; }
    }
}


// İşte Solid deki tek sorumlukuk yani customer Adrese ait bilgileri almaz 