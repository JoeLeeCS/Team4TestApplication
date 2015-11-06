using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public class PromotionOne : Promotion
    {
        public double calculatePrice(Order order)
        {
            Double result = 0;
            OrderItem prevOrderItem = null;
            order.SortBySku();
            foreach (var orderItem in order.Items)
            {
                double perItemPrice = orderItem.Product.Price;

                if (orderItem.Quantity % 2 == 0)
                {
                    result += orderItem.Quantity * orderItem.Product.Price * 0.85; // Applying Discount 2
                    
                }
                else
                {
                    double itemPrice = perItemPrice;
                    // IF there is an odd number in current order and a previous order, check if the item is able to satisfy Discount3, apply discount to the odd number in this 
                    if (prevOrderItem != null && SKU.isSameStyle(orderItem.Product.Sku, prevOrderItem.Product.Sku))
                    {
                        itemPrice = 0.5 * itemPrice; // Applying Discount 3
                        prevOrderItem = null;
                    }
                    else
                    {
                        prevOrderItem = orderItem; // Store the previous item for considering the next item if it is not already discounted.
                    }
                    result += ( (orderItem.Quantity - 1) * orderItem.Product.Price * 0.85) + itemPrice;
                    Console.WriteLine("result");
                }

            }
            return result;
        }
    }
}
