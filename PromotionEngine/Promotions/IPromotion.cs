using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Promotions
{
    public interface IPromotion
    {
        bool ApplyPromotion(Cart cart);
    }
}
