using System.Collections.Generic;
using Assignment.DiscountShop.Contracts;
using Assignment.DiscountShop.DiscountShopService;
using Assignment.DiscountShop.Models;
using NUnit.Framework;

namespace Assignment.DiscountShop.Tests
{
    public class ShoppingCartServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ComputeBillScenarioATest()
        {
            IShoppingCartService scs = new ShoppingCartService();
            CustomerService cs = new CustomerService(scs);
            int custId = cs.CreateCustomer("Paniraj N");
            ShoppingCart shoppingCart = cs.CreateShoppingCart(custId);

            
            ProductService ps = new ProductService();
            Product pA = ps.CreateProduct("A", "product A", 50);
            Product pB = ps.CreateProduct("B", "product B", 30);
            Product pC = ps.CreateProduct("C", "product C", 20);

            DiscountService ds = new DiscountService();
            var discountA = ds.CreateDiscount("Discount on A", "Discount if Purchase 3 As");
            KeyValuePair<Product, int> pAs = new KeyValuePair<Product,int>(pA, 3);
            List<KeyValuePair<Product, int>> discountCombinationAs = new List<KeyValuePair<Product, int>>();
            discountCombinationAs.Add(pAs);
            DiscountCombinationItems dci = new DiscountCombinationItems(discountCombinationAs,
                20, 0);

            ds.CreateDiscountCombinationItems(discountA.Id, dci);

            scs.AddItem(shoppingCart, pA, 1);
            scs.AddItem(shoppingCart, pB, 1);
            scs.AddItem(shoppingCart, pC, 1);

            shoppingCart = scs.ComputeBill(shoppingCart);

            Assert.AreEqual(100, shoppingCart.TotalBillAmount);
        }
        [Test]
        public void ComputeBillScenarioBTest()
        {
            IShoppingCartService scs = new ShoppingCartService();
            CustomerService cs = new CustomerService(scs);
            int custId = cs.CreateCustomer("Paniraj N");
            ShoppingCart shoppingCart = cs.CreateShoppingCart(custId);


            ProductService ps = new ProductService();
            Product pA = ps.CreateProduct("A", "product A", 50);
            Product pB = ps.CreateProduct("B", "product B", 30);
            Product pC = ps.CreateProduct("C", "product C", 20);
            Product pD = ps.CreateProduct("D", "product D", 15);

            DiscountService ds = new DiscountService();
            var discountA = ds.CreateDiscount("Discount on A", "Discount if Purchase 3 As");
            KeyValuePair<Product, int> pAs = new KeyValuePair<Product, int>(pA, 3);
            List<KeyValuePair<Product, int>> discountCombinationAs = new List<KeyValuePair<Product, int>>();
            discountCombinationAs.Add(pAs);
            DiscountCombinationItems dci = new DiscountCombinationItems(discountCombinationAs,
                20, 0);

            ds.CreateDiscountCombinationItems(discountA.Id, dci);

            //Discount B
            var discountB = ds.CreateDiscount("Discount on B", "Discount if Purchase 2 Bs");
            KeyValuePair<Product, int> pBs = new KeyValuePair<Product, int>(pB, 2);
            List<KeyValuePair<Product, int>> discountCombinationBs = new List<KeyValuePair<Product, int>>();
            discountCombinationBs.Add(pBs);
            DiscountCombinationItems dc2 = new DiscountCombinationItems(discountCombinationBs,
                15, 0);

            ds.CreateDiscountCombinationItems(discountB.Id, dc2);

            scs.AddItem(shoppingCart, pA, 5);
            scs.AddItem(shoppingCart, pB, 5);
            scs.AddItem(shoppingCart, pC, 1);

            shoppingCart = scs.ComputeBill(shoppingCart);

            Assert.AreEqual(370, shoppingCart.TotalBillAmount);
        }
        [Test]
        public void ComputeBillScenarioCTest()
        {
            IShoppingCartService scs = new ShoppingCartService();
            CustomerService cs = new CustomerService(scs);
            int custId = cs.CreateCustomer("Paniraj N");
            ShoppingCart shoppingCart = cs.CreateShoppingCart(custId);


            ProductService ps = new ProductService();
            Product pA = ps.CreateProduct("A", "product A", 50);
            Product pB = ps.CreateProduct("B", "product B", 30);
            Product pC = ps.CreateProduct("C", "product C", 20);
            Product pD = ps.CreateProduct("D", "product D", 15);

            DiscountService ds = new DiscountService();
            //Discount A
            var discountA = ds.CreateDiscount("Discount on A", "Discount if Purchase 3 As");
            KeyValuePair<Product, int> pAs = new KeyValuePair<Product, int>(pA, 3);
            List<KeyValuePair<Product, int>> discountCombinationAs = new List<KeyValuePair<Product, int>>();
            discountCombinationAs.Add(pAs);
            DiscountCombinationItems dci = new DiscountCombinationItems(discountCombinationAs,
                20, 0);

            ds.CreateDiscountCombinationItems(discountA.Id, dci);

            //Discount B
            var discountB = ds.CreateDiscount("Discount on B", "Discount if Purchase 2 Bs");
            KeyValuePair<Product, int> pBs = new KeyValuePair<Product, int>(pB, 2);
            List<KeyValuePair<Product, int>> discountCombinationBs = new List<KeyValuePair<Product, int>>();
            discountCombinationBs.Add(pBs);
            DiscountCombinationItems dc2 = new DiscountCombinationItems(discountCombinationBs,
                15, 0);

            ds.CreateDiscountCombinationItems(discountB.Id, dc2);

            //Discount C + D
            var discountCD = ds.CreateDiscount("Discount on C & D", "Discount if Purchase C & Ds");
            KeyValuePair<Product, int> pCs = new KeyValuePair<Product, int>(pC, 1);
            KeyValuePair<Product, int> pDs = new KeyValuePair<Product, int>(pD, 1);
            List<KeyValuePair<Product, int>> discountCombinationCDs = new List<KeyValuePair<Product, int>>();
            discountCombinationCDs.Add(pCs);
            discountCombinationCDs.Add(pDs);
            DiscountCombinationItems dc3 = new DiscountCombinationItems(discountCombinationCDs,
                5, 0);

            ds.CreateDiscountCombinationItems(discountCD.Id, dc3);

            scs.AddItem(shoppingCart, pA, 3);
            scs.AddItem(shoppingCart, pB, 5);
            scs.AddItem(shoppingCart, pC, 1);
            scs.AddItem(shoppingCart, pD, 1);

            shoppingCart = scs.ComputeBill(shoppingCart);

            Assert.AreEqual(280, shoppingCart.TotalBillAmount);
        }
    }
}