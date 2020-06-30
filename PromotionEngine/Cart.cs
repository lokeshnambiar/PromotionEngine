using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Cart
    {
        private List<ProductItem> products;
        private List<ValuePackItem> valueItems;

        public Cart()
        {
            products = new List<ProductItem>();
            valueItems = new List<ValuePackItem>();
        }
        public void AddItem(ProductItem item)
        {
            products.Add(item);
        }

        public void AddValueItem(ValuePackItem valueItem)
        {
            valueItems.Add(valueItem);
        }

        public void RemoveItem(ProductItem item)
        {
            products.Remove(item);
        }

        public void RemoveValueItem(ValuePackItem item)
        {
            valueItems.Remove(item);
        }

        public List<ProductItem> GetItems()
        {
            return products;
        }

        public List<ValuePackItem> GetValueItems()
        {
            return valueItems;
        }
    }
}
