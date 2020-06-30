using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromotionEngine.Promotions;

namespace PromotionEngine
{
    public class Checkout
    {
        private Cart cart;
        private List<IPromotion> promotions;
        public Checkout(Cart cart,List<IPromotion> promotions)
        {
            this.cart = cart;
            this.promotions = promotions;
        }

        private void ApplyPromotions()
        {
            foreach (IPromotion promotion in promotions)
            {
                bool isPromotionApplied = promotion.ApplyPromotion(cart);
                if (isPromotionApplied) break;
            }
        }
    }
}
