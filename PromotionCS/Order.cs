using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PromotionCS
{
    public class Order
    {
        public List<OrderItem> Items { get; set; }

        public Order()
        {
            Items = new List<OrderItem>();
        }

        public double TotalPrice
        {
            get
            {
                double total = 0;
                if (this.promotion != null)
                {
                    total = this.promotion.calculatePrice(this);
                }
                else
                {
                    foreach (OrderItem item in Items)
                    {
                        total += item.Product.Price * item.Quantity;
                    }
                }

                return total;
            }
        }

        public void Add(Product product, int qty)
        {
            OrderItem oi = GetOrderItem(product.Sku.Name);

            if (oi == null)
            {
                oi = new OrderItem();
                oi.Product = product;
                oi.Quantity = qty;
                Items.Add(oi);
                SortBySku();
            }
            else
            {
                oi.Quantity += qty;
            }

        }

        public OrderItem GetOrderItem(string sku)
        {
            return Items.Find(o => o.Product.Sku.Name == sku);
        }

        public void SortBySku()
        {
            Items.Sort(delegate(OrderItem item1, OrderItem item2)
            {
                return item1.Product.Sku.Name.CompareTo(item2.Product.Sku.Name);
            });
        }

        public Dictionary<String, List<OrderItem>> getItemByStyle()
        {
            Dictionary<String, List<OrderItem>> result = new Dictionary<string, List<OrderItem>>();
            foreach (var orderItem in this.Items)
            {
                List<OrderItem> listOfOrderItem = null;
                if (!result.ContainsKey(orderItem.Product.Sku.Style))
                {
                    listOfOrderItem = new List<OrderItem>();
                    result.Add(orderItem.Product.Sku.Style, listOfOrderItem);
                }
                else
                {
                    listOfOrderItem = result[orderItem.Product.Sku.Style];
                }
                listOfOrderItem.Add(orderItem);
            }

            return result;
        }

        private Promotion promotion;

        public Promotion Promotion
        {
            get { return promotion; }
            set { promotion = value; }
        }

    }

    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
