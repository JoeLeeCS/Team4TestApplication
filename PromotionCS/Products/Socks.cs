using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS.Products
{
    public class Socks : Product
    {
        public Socks(SKU sku, string name, double price) : base(sku, name, price)
        {
        }
    }
}
