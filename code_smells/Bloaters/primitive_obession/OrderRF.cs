using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Bloaters.primitive_obession
{
    public class OrderRF
    {
        public int OrderID { get; set; }
        public OrderNumber OrderNumber { get; set; }
        public Money OrderTotal { get; set; }
        public DateTime OrderDate { get; set; }
        public CustomerInfo Customer { get; set; }
        public ProductInfo Product { get; set; }
        public int Quantity { get; set; }
    }

    public class OrderNumber
    {
        public string Value { get; }

        public OrderNumber(string value)
        {
            // Validar y asignar el número de pedido
            Value = value;
        }
    }

    public class Money
    {
        public decimal Amount { get; }

        public Money(decimal amount)
        {
            // Validar y asignar el monto
            Amount = amount;
        }
    }

    public class CustomerInfo
    {
        public string Name { get; }
        public string Email { get; }

        public CustomerInfo(string name, string email)
        {
            // Validar y asignar el nombre y el correo electrónico del cliente
            Name = name;
            Email = email;
        }
    }

    public class ProductInfo
    {
        public string Name { get; }
        public decimal Price { get; }

        public ProductInfo(string name, decimal price)
        {
            // Validar y asignar el nombre y el precio del producto
            Name = name;
            Price = price;
        }
    }

}
