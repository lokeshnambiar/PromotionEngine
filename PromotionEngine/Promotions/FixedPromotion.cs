using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    class FixedPromotion:IPromotion
    {
        public bool ApplyPromotion(Cart cart)
        {
            //Incomplete
            //List<ProductItem> items = cart.GetItems();
            //var itemWithSkuC = items.Where(i=>i.Sku.Equals("C"));
            //var itemWithSkuD = items.Where(i=>i.Sku.Equals("D"));
            //int maxCount =0;
            //if(itemWithSkuC.Count<ProductItem>() > itemWithSkuD.Count<ProductItem>()){
            //    maxCount = itemWithSkuD.Count<ProductItem>();
            //}else{
            //    maxCount = itemWithSkuC.Count<ProductItem>();
            //}
            //for(int i=0; i<maxCount;i++){
            //    ValuePackItem valueItem = new ValuePackItem();
            //    ProductItem item1 = new ProductItem();
            //    item.Sku = "C";
            //    ProductItem item2 = new ProductItem();
            //    item.Sku = "D";
            //    Price price = new Price();
            //    price.ListPrice = 30;
            //    price.DiscountedPrice = 30;
            //    valueItem.DiscountedPrice = price;
            
            //}

            return true;
        }
    }
}
