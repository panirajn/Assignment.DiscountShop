using System.Collections.Generic;
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
            CustomerService cs = new CustomerService();
            int custId = cs.CreateCustomer("Paniraj N");
            ShoppingCart shoppingCart = cs.CreateShoppingCart(custId);

            
            ProductService ps = new ProductService();
            Product pA = ps.CreateProduct("A", "product A", 50);
            Product pB = ps.CreateProduct("B", "product B", 30);
            Product pC = ps.CreateProduct("C", "product C", 20);
            Product pD = ps.CreateProduct("D", "product D", 15);

            DiscountService ds = new DiscountService();
            var discountA = ds.CreateDiscount("Discount on A", "Discount if Purchase 3 As");
            KeyValuePair<Product, int> pAs = new KeyValuePair<Product,int>(pA, 3);
            List<KeyValuePair<Product, int>> discountCombinationAs = new List<KeyValuePair<Product, int>>();
            discountCombinationAs.Add(pAs);
            DiscountCombinationItems dci = new DiscountCombinationItems(discountCombinationAs,
                20, 0);

            ds.CreateDiscountCombinationItems(discountA.Id, dci);

            ShoppingCartService scs = new ShoppingCartService();
            scs.AddItem(shoppingCart, pA, 1);
            scs.AddItem(shoppingCart, pB, 1);
            scs.AddItem(shoppingCart, pC, 1);

            shoppingCart = scs.ComputeBill(shoppingCart);

            Assert.AreEqual(100, shoppingCart.TotalBillAmount);
        }
        [Test]
        public void ComputeBillScenarioBTest()
        {
            CustomerService cs = new CustomerService();
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

            ShoppingCartService scs = new ShoppingCartService();
            scs.AddItem(shoppingCart, pA, 5);
            scs.AddItem(shoppingCart, pB, 5);
            scs.AddItem(shoppingCart, pC, 1);

            shoppingCart = scs.ComputeBill(shoppingCart);

            Assert.AreEqual(370, shoppingCart.TotalBillAmount);
        }
        [Test]
        public void ComputeBillScenarioCTest()
        {
            CustomerService cs = new CustomerService();
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

            ShoppingCartService scs = new ShoppingCartService();
            scs.AddItem(shoppingCart, pA, 3);
            scs.AddItem(shoppingCart, pB, 5);
            scs.AddItem(shoppingCart, pC, 1);
            scs.AddItem(shoppingCart, pD, 1);

            shoppingCart = scs.ComputeBill(shoppingCart);

            Assert.AreEqual(280, shoppingCart.TotalBillAmount);
        }
    }
}