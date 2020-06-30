using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace PromotionEngine.Promotions
{
    class ValuePromotion : IPromotion
    {
        public bool ApplyPromotion(Cart cart)
        {
            List<ProductItem> items = cart.GetItems();
            IDictionary<string,int> skusCount = new Dictionary<string,int>();
            foreach (ProductItem item in items)
            {
                if (skusCount.ContainsKey(item.Sku))
                {
                    skusCount[item.Sku]++;
                }
                else
                {
                    skusCount[item.Sku] = 0;
                }
            }
            foreach(string key in skusCount.Keys){
                 if(key == "A"){
                     var item = items.Where(i => i.Sku == "A");
                     (item as ProductItem).ListPrice.DiscountedPrice = 130 * GetMultipleThreeFactor(skusCount[key]);
                 }
            }
            return true;
        }

        private int GetMultipleThreeFactor(int no)
        {
            int noOfTimes = 0;
            for (int i = 1; i <= no; i++)
                if (i % 3 == 0) noOfTimes++;
            return noOfTimes; 
        }
    }
}
