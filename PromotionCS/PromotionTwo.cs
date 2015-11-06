using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public class PromotionTwo : Promotion
    {
        public double calculatePrice(Order order)
        {
            Double result = 0;
            foreach (var orderItems in order.getItemByStyle().Values)
            {
                foreach (OrderItem orderItem in orderItems)
                {
                    if (orderItems.Count <= 1 && orderItem.Quantity <= 1)
                    {
                        result += orderItem.Product.Price * 0.9; // 10% off for 1 item of a style
                    }
                    else
                    {
                        result += orderItem.Quantity * orderItem.Product.Price * 0.8; // 20% for 2 or more item of same style.
                    }
                }
            }
            return result;
        }
    }
}
