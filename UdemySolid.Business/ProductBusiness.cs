using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemySolid.Entity;

namespace UdemySolid.Business
{
    public class ProductBusiness:_BaseBusiness<Product>
    {
        public double GetTotalPrices(double price,double taxs)
        {
            double totalPrices = price + (price / 100 * taxs);
            return totalPrices;
        }
    }
}
