using PromotionCS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1ABuy1Item();
            Order order = new Order();
            Promotion promo = new PromotionOne(); //TODO: setup the promotion as you see fit
            order.Promotion = promo;
            //DiscountCalculator dc = new DiscountCalculator(promo);
            List<Order> orders = new List<Order>();
            orders.Add(order);
            while (true)
            {

                Console.WriteLine(DisplayMainMenu());
                String a = Console.ReadLine();

                int optionSelected;
                if (Int32.TryParse(a, out optionSelected))
                {
                    switch (optionSelected)
                    {
                        case 1:
                            int optionSelected2 = -1;
                            while (optionSelected2 != 0)
                            {
                                Console.WriteLine(DisplayProductMenu());
                                String b = Console.ReadLine();
                                if (Int32.TryParse(b, out optionSelected2))
                                {

                                    switch (optionSelected2)
                                    {
                                        case 1:
                                            order.Add(Products.GetProduct("blueDress"), 1);
                                            break;
                                        case 2:
                                            order.Add(Products.GetProduct("redDress"), 1);
                                            break;
                                        case 3:
                                            order.Add(Products.GetProduct("greenDress"), 1);
                                            break;
                                        case 4:
                                            order.Add(Products.GetProduct("whiteSocks"), 1);
                                            break;
                                        case 5:
                                            order.Add(Products.GetProduct("redSocks"), 1);
                                            break;
                                    }

                                    Console.WriteLine("======Total Price: " + order.TotalPrice + "======");
                                }
                            }


                            break;
                        case 2:
                            Console.WriteLine(order.toString());
                            break;
                        case 3:
                            Console.WriteLine(DisplayPromotionType());
                            String c = Console.ReadLine();
                            int optionSelected3 = -1;
                            if (Int32.TryParse(c, out optionSelected3))
                            {
                                Promotion promotion = order.Promotion;
                                switch (optionSelected3)
                                {
                                    case 1:
                                        promotion = new PromotionOne();
                                        break;
                                    case 2:
                                        promotion = new PromotionTwo();
                                        break;
                                    case 3:
                                        promotion = new PromotionThree();
                                        break;
                                    case 4:
                                        promotion = null;
                                        break;
                                    case 0:
                                        break;
                                    default:
                                        break;
                                }
                                order.Promotion = promotion;

                                Console.WriteLine("======Total Price with selected Promotion: " + order.TotalPrice + "======");
                            }
                            break;
                        case 4:
                            Console.WriteLine("======Total Price: " + order.TotalPrice + "======");
                            break;
                        case 5:
                            order = new Order();
                            orders.Add(order);
                            break;
                        case 6:
                            Console.WriteLine("Checking out is not yet supported.");
                            break;
                    }
                }

            }
        }


        private static String DisplayMainMenu()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\n\n------------------------\n");
            result.Append("1: Add a product\n");
            result.Append("2: View Cart\n");
            result.Append("3: Set a Discount\n");
            result.Append("4: Calculate FInal Price\n");
            result.Append("5: New Order\n");
            result.Append("6: Check out\n");
            result.Append("------------------------\n");
            result.Append("User Input : ");
            return result.ToString();
        }

        private static String DisplayProductMenu()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\n\n------------------------\n");
            result.Append("1: Add a Blue Dress\n");
            result.Append("2: Add a Red Dress\n");
            result.Append("3: Add a Green Dress\n");
            result.Append("4: Add a White Socks\n");
            result.Append("5: Add a Red Socks\n");
            result.Append("0: Back to Home\n");
            result.Append("------------------------\n");
            result.Append("User Input : ");
            return result.ToString();
        }

        private static String DisplayPromotionType()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\n\n------------------------\n");
            result.Append("1: Promotion 1\n");
            result.Append("2: Promotion 2\n");
            result.Append("3: Promotion 3\n");
            result.Append("4: No Promotion\n");
            result.Append("0: Back to Home\n");
            result.Append("------------------------\n");
            result.Append("User Input : ");
            return result.ToString();
        }

        public class Products
        {
            static Dictionary<string, Product> products = new Dictionary<string, Product>();

            static Products()
            {
                products.Add("redDress", new Product(new SKU("1001", ".1"), "Red Dress", 100.0));
                products.Add("greenDress", new Product(new SKU("1001", ".2"), "Green Dress", 100.0));
                products.Add("blueDress", new Product(new SKU("1001", ".3"), "Blue Dress", 100.0));
                products.Add("whiteSocks", new Product(new SKU("2001", ".1"), "White Socks", 10.0));
                products.Add("redSocks", new Product(new SKU("2001", ".2"), "Red Socks", 10.0));
            }

            public static Product GetProduct(string name)
            {
                return products[name];
            }
        }
    }
}
