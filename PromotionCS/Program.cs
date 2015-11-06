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
            Test1ABuy1Item();
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
                            if (optionSelected2 != 0)
                            {
                                Console.WriteLine(DisplayProductMenu());
                                String b = Console.ReadLine();
                                if (Int32.TryParse(a, out optionSelected2))
                                {

                                    switch (optionSelected2)
                                    {
                                        case 1:
                                            break;
                                    }
                                }
                            }


                            break;
                        case 2:
                            break;
                    }
                }

            }
        }


        private static String DisplayMainMenu()
        {
            StringBuilder result = new StringBuilder();
            result.Append("1: Add a product\n");
            result.Append("2: View Cart\n");
            result.Append("3: Set a Discount\n");
            result.Append("4: Calculate FInal Price\n");
            return result.ToString();
        }

        private static String DisplayProductMenu()
        {
            StringBuilder result = new StringBuilder();
            result.Append("1: Add a Blue Dress\n");
            result.Append("2: Add a Red Dress\n");
            result.Append("3: Add a Green Dress\n");
            result.Append("4: Add a White Socks\n");
            result.Append("5: Add a Red Socks\n");
            result.Append("6: Back to Home\n");
            var a = "a";
            return result.ToString();
        }


        public static void Test1ABuy1Item()
        {
            //setup
            Promotion promo = new PromotionTwo(); //TODO: setup the promotion as you see fit
            DiscountCalculator dc = new DiscountCalculator(promo);


            Order o = new Order();
            o.Add(Products.GetProduct("blueDress"), 1);
            o.Add(Products.GetProduct("redDress"), 3);
            o.Add(Products.GetProduct("greenDress"), 2);
            //o.Add(Products.GetProduct("whiteSocks"), 1);
            //o.Add(Products.GetProduct("redSocks"), 1);

            //exercise
            Order newOrder = dc.CalculateDiscount(o);

            //verify
            double expectedValue = 100 * 3 + 10 * 2;//TODO: set the expected value;

            double totalPrice = newOrder.TotalPrice;

            //TODO: add additional verification if necessary
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
