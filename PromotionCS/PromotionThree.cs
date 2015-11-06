using PromotionCS.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public class PromotionThree : Promotion
    {
        public double calculatePrice(Order order)
        {
            Double result = 0;
            foreach (var orderItem in order.Items)
            {
                if (orderItem.Product is WomansInvisibleSocks)
                {
                    int quantityNotInBundle = orderItem.Quantity % 3;
                    // Adding the quantity not qualify for bundle deal
                    result +=  quantityNotInBundle * orderItem.Product.Price;
                    // Adding the quantity in bundle deal
                    result += ((orderItem.Quantity - quantityNotInBundle) / 3) * 25;
                }
                else
                {
                    result += orderItem.Product.Price * orderItem.Quantity;
                }
            }
            return result;
        }
    }
}
