using System.Collections.Generic;
using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        void CreateProduct(Product prod);
        void DeactivateProduct(Product prod);
        void ActivateProduct(Product prod);
    }
}