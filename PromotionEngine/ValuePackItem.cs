using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class ValuePackItem
    {
        public int ItemId { get; set; }
        public List<ProductItem> Items { get; set; }
        public Price DiscountedPrice { get; set; }
    }
}
