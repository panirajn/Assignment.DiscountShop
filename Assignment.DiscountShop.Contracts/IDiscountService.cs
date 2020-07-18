using System.Collections.Generic;
using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.Contracts
{
    public interface IDiscountService
    {
        IEnumerable<Discount> GetAll();
        Discount Get(int id);
        Discount CreateDiscount(Discount discount);
        DiscountCombinationItems CreateDiscountCombinationItems();
        Discount UpdateDiscountCombinationItems(DiscountCombinationItems discountCombinationItems);
        void DeactivateDiscount(Discount discount);
        void ActivateDiscount(Discount discount);
    }
}