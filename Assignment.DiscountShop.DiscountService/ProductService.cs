using System;
using System.Collections.Generic;
using System.Text;
using Assignment.DiscountShop.Contracts;
using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.DiscountService
{
    public class ProductService:IProductService
    {
        List<Product> products = new List<Product>();
        Product IProductService.CreateProduct(Product prod)
        {
            throw new NotImplementedException();
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
