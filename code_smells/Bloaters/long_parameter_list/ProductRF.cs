using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Bloaters.long_parameter_list
{
    public class ProductRF
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ShoppingCartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public bool ApplyDiscount { get; set; }
        public bool IsGift { get; set; }
        public bool IsPriority { get; set; }
    }

    public class ShoppingCartRF
    {
        public void AddProductToCart(int userId, ShoppingCartItem cartItem)
        {
            // Lógica para agregar un producto al carrito
        }
    }

}
