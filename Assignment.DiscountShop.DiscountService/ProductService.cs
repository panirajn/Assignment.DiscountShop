using System;
using System.Collections.Generic;
using System.Linq;
using Assignment.DiscountShop.Contracts;
using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.DiscountShopService
{
    public class ProductService:IProductService
    {
        List<Product> products = new List<Product>();
        public Product CreateProduct(string name, string description, decimal costPerUnit)
        {
            int maxId = products.Select(c => c.Id)
                .DefaultIfEmpty(0).Max();
            products.Add(new Product(++maxId, name, description, costPerUnit));
            return products[maxId];
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateProduct(Product prod)
        {
            throw new NotImplementedException();
        }

        public void DeactivateProduct(Product prod)
        {
            throw new NotImplementedException();
        }

        public void ActivateProduct(Product prod)
        {
            throw new NotImplementedException();
        }

    }
}
