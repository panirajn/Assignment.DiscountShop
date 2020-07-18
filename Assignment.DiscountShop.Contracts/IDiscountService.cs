using System.Collections.Generic;
using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.Contracts
{
    public interface IDiscountService
    {
        IEnumerable<Discount> GetAll();
        Discount Get(int id);
        void CreateDiscount(Discount discount);
        void DeactivateDiscount(Discount discount);
        void ActivateDiscount(Discount discount);
    }
}