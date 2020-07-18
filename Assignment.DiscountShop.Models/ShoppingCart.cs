using System.Collections.Generic;

namespace Assignment.DiscountShop.Models
{
    public class ShoppingCart
    {
        public ShoppingCart(int id, int customerId)
        {
            Id = id;
            CustomerId = customerId;
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<KeyValuePair<Product, int>> CartItems { get; set; }
        public IEnumerable<KeyValuePair<Discount, decimal>> DiscountsApplied { get; set; }

        public decimal TotalBillAmount { get; set; }
    }
}