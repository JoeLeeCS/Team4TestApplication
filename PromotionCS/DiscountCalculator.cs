using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public class DiscountCalculator
    {
        public DiscountCalculator(Promotion promotion)
        {
            this.promotion = promotion;
        }

        public Order CalculateDiscount(Order order)
        {
            //your implementation here
            order.Promotion = this.promotion;

            return order;
        }

        private Promotion promotion;

        public Promotion Promotion
        {
            get { return promotion; }
            set { promotion = value; }
        }
    }

}
