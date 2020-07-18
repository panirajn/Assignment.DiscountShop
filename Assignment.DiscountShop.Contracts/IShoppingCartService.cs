using Assignment.DiscountShop.Models;

namespace Assignment.DiscountShop.Contracts
{
    public interface IShoppingCartService
    {
        void AddItem(ShoppingCart shoppingCart, Product product, int count);
        void RemoveItem(ShoppingCart shoppingCart, Product product, int count);

        ShoppingCart ComputeBill(ShoppingCart shoppingCart);
        ShoppingCart Checkout(ShoppingCart shoppingCart);
    }
}