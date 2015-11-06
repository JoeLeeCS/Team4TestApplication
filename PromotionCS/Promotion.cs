using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public interface Promotion
    {
        //public enum PromotionTypes { NONE, ONE, TWO, THREE };

        //private PromotionTypes promotionType;

        //public PromotionTypes PromotionType
        //{
        //    get { return promotionType; }
        //    set { promotionType = value; }
        //}
        double calculatePrice(Order order);
        
    }
}
