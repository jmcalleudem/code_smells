using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Couplers.feature_envy
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Discount { get; set; }
    }

    public class Order
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var product in Products)
            {
                decimal discountedPrice = product.Price * (1 - Customer.Discount);
                totalPrice += discountedPrice;
            }

            return totalPrice;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

}
