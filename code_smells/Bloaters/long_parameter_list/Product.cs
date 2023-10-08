using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Bloaters.long_parameter_list
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ShoppingCart
    {
        public void AddProductToCart(int userId, Product product, int quantity, bool applyDiscount, bool isGift, bool isPriority)
        {
            // Lógica para agregar un producto al carrito
        }
    }

}
