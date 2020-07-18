using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.Contracts
{
    public interface ICustomerService
    {
        ShoppingCart CreateShoppingCart(int customerId);
        ShoppingCart Checkout();
        ShoppingCart ComputeBill();
    }
}