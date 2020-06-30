using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Cart
    {
        private List<string> skus;

        public Cart()
        {
            skus = new List<string>();
        }
        public void AddItem(string sku)
        {
            skus.Add(sku);
        }

        public void RemoveItem(string sku)
        {
            skus.Remove(sku);
        }

        public List<string> GetItem(string sku)
        {
            return skus;
        }
    }
}
