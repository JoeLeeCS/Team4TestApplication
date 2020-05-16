using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionCS;

namespace TestProject
{
    [TestClass]
    public class DiscountTest
    {
        [TestMethod]
        public void Test1ABuy1Item()
        {
            //setup
            Promotion promo = new PromotionOne(); //TODO: setup the promotion as you see fit
            DiscountCalculator dc = new DiscountCalculator(promo);


            Order o = new Order();
            o.Add(Products.GetProduct("blueDress"), 1);
            //o.Add(Products.GetProduct("redDress"), 3);
            //o.Add(Products.GetProduct("greenDress"), 3);
            //o.Add(Products.GetProduct("whiteSocks"), 3);
            //o.Add(Products.GetProduct("redSocks"), 3);

            //exercise
            Order newOrder = dc.CalculateDiscount(o);

            //verify
            double expectedValue = 100;

            Assert.AreEqual(expectedValue, newOrder.TotalPrice, 0.001);
            //TODO: add additional verification if necessary
        }

        public void Test1ABuy2Item()
        {
            //setup
            Promotion promo = new PromotionOne(); //TODO: setup the promotion as you see fit
            DiscountCalculator dc = new DiscountCalculator(promo);


            Order o = new Order();
            o.Add(Products.GetProduct("blueDress"), 2);
            //o.Add(Products.GetProduct("redDress"), 3);
            //o.Add(Products.GetProduct("greenDress"), 3);
            //o.Add(Products.GetProduct("whiteSocks"), 3);
            //o.Add(Products.GetProduct("redSocks"), 3);

            //exercise
            Order newOrder = dc.CalculateDiscount(o);

            //verify
            double expectedValue = 170;

            Assert.AreEqual(expectedValue, newOrder.TotalPrice, 0.001);
            //TODO: add additional verification if necessary
        }

        public void Test1ABuy3Item()
        {
            //setup
            Promotion promo = new PromotionOne(); //TODO: setup the promotion as you see fit
            DiscountCalculator dc = new DiscountCalculator(promo);


            Order o = new Order();
            o.Add(Products.GetProduct("blueDress"), 3);
            //o.Add(Products.GetProduct("redDress"), 3);
            //o.Add(Products.GetProduct("greenDress"), 3);
            //o.Add(Products.GetProduct("whiteSocks"), 3);
            //o.Add(Products.GetProduct("redSocks"), 3);

            //exercise
            Order newOrder = dc.CalculateDiscount(o);

            //verify
            double expectedValue = 100 + +170;

            Assert.AreEqual(expectedValue, newOrder.TotalPrice, 0.001);
            //TODO: add additional verification if necessary
        }

        public void Test1ABuyMultipleItem()
        {
            //setup
            Promotion promo = new PromotionOne(); //TODO: setup the promotion as you see fit
            DiscountCalculator dc = new DiscountCalculator(promo);


            Order o = new Order();
            o.Add(Products.GetProduct("blueDress"), 1);
            o.Add(Products.GetProduct("redDress"), 3);
            o.Add(Products.GetProduct("greenDress"), 3);
            o.Add(Products.GetProduct("whiteSocks"), 3);
            o.Add(Products.GetProduct("redSocks"), 3);

            //exercise
            Order newOrder = dc.CalculateDiscount(o);

            //verify
            double expectedValue = 100 + +170 + 50 + 170 + 100 + 10 + 17 + 5 + 17;

            Assert.AreEqual(expectedValue, newOrder.TotalPrice, 0.001);
            //TODO: add additional verification if necessary
        }

        [TestMethod]
        public void Test2ABuy1Item()
        {
            //setup
            Promotion promo = new PromotionTwo(); //TODO: setup the promotion as you see fit
            DiscountCalculator dc = new DiscountCalculator(promo);


            Order o = new Order();
            o.Add(Products.GetProduct("blueDress"), 1);
            //o.Add(Products.GetProduct("redDress"), 3);
            //o.Add(Products.GetProduct("greenDress"), 3);
            //o.Add(Products.GetProduct("whiteSocks"), 1);
            //o.Add(Products.GetProduct("redSocks"), 3);

            //exercise
            Order newOrder = dc.CalculateDiscount(o);

            //verify
            double expectedValue = 90;

            Assert.AreEqual(expectedValue, newOrder.TotalPrice, 0.001);
            //TODO: add additional verification if necessary
        }


        [TestMethod]
        public void Test3ABuy3InvisibleSocks()
        {
            //setup
            Promotion promo = new PromotionThree(); //TODO: setup the promotion as you see fit
            DiscountCalculator dc = new DiscountCalculator(promo);


            Order o = new Order();
            o.Add(Products.GetProduct("blueDress"), 1);
            o.Add(Products.GetProduct("redDress"), 3);
            o.Add(Products.GetProduct("greenDress"), 3);
            o.Add(Products.GetProduct("whiteSocks"), 1);
            o.Add(Products.GetProduct("womansInvisibleSocks"), 3);

            //exercise
            Order newOrder = dc.CalculateDiscount(o);

            //verify
            double expectedValue = 700 + 10 + 25;

            Assert.AreEqual(expectedValue, newOrder.TotalPrice, 0.001);
            //TODO: add additional verification if necessary
        }

        [TestMethod]
        public void Test3ABuy4InvisibleSocks()
        {
            //setup
            Promotion promo = new PromotionThree(); //TODO: setup the promotion as you see fit
            DiscountCalculator dc = new DiscountCalculator(promo);


            Order o = new Order();
            o.Add(Products.GetProduct("blueDress"), 1);
            o.Add(Products.GetProduct("redDress"), 3);
            o.Add(Products.GetProduct("greenDress"), 3);
            o.Add(Products.GetProduct("whiteSocks"), 1);
            o.Add(Products.GetProduct("womansInvisibleSocks"), 4);

            //exercise
            Order newOrder = dc.CalculateDiscount(o);

            //verify
            double expectedValue = 700 + 10 + 25 + 1000;

            Assert.AreEqual(expectedValue, newOrder.TotalPrice, 0.001);
            //TODO: add additional verification if necessary
        }
        [TestMethod]
        public void Test3ABuy1InvisibleSocks()
        {
            //setup
            Promotion promo = new PromotionThree(); //TODO: setup the promotion as you see fit
            DiscountCalculator dc = new DiscountCalculator(promo);


            Order o = new Order();
            o.Add(Products.GetProduct("blueDress"), 1);
            o.Add(Products.GetProduct("redDress"), 3);
            o.Add(Products.GetProduct("greenDress"), 3);
            o.Add(Products.GetProduct("whiteSocks"), 1);
            o.Add(Products.GetProduct("womansInvisibleSocks"), 1); ;

            //exercise
            Order newOrder = dc.CalculateDiscount(o);

            //verify
            double expectedValue = 700 + 10 + 1000;

            Assert.AreEqual(expectedValue, newOrder.TotalPrice, 0.001);
            //TODO: add additional verification if necessary
        }
    }
}
