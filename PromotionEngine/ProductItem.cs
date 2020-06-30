using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class ProductItem
    {
        public int ItemId { get; set; }
        public Price ListPrice { get; set; }
        public string Sku { get; set; }
        public Price DiscountedPrice { get; set; }
    }
}
