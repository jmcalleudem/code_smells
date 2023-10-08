using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Couplers.feature_envy
{
    public class CustomerRF
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Discount { get; set; }

        public decimal ApplyDiscount(decimal price)
        {
            return price * (1 - Discount);
        }
    }

    public class OrderRF
    {
        public CustomerRF Customer { get; set; }
        public List<Product> Products { get; set; }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var product in Products)
            {
                decimal discountedPrice = Customer.ApplyDiscount(product.Price);
                totalPrice += discountedPrice;
            }

            return totalPrice;
        }
    }

    public class ProductRF
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

}
