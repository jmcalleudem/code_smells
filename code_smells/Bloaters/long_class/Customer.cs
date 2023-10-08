using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Bloaters.long_class
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public decimal AccountBalance { get; set; }
        public List<Order> Orders { get; set; }
        public List<PaymentMethod> PaymentMethods { get; set; }
        public List<Review> Reviews { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
            PaymentMethods = new List<PaymentMethod>();
            Reviews = new List<Review>();
        }

        public void PlaceOrder(Order order)
        {
            // Lógica para realizar un pedido
        }

        public void AddPaymentMethod(PaymentMethod paymentMethod)
        {
            // Lógica para agregar un método de pago
        }

        public void AddReview(Review review)
        {
            // Lógica para agregar una reseña
        }

        public void UpdateProfile(string firstName, string lastName, string email, string phoneNumber, DateTime dateOfBirth, string addressLine1, string addressLine2, string city, string state, string zipCode, string country)
        {
            // Lógica para actualizar el perfil del cliente
        }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        // Otras propiedades de la orden...
    }

    public class PaymentMethod
    {
        public int PaymentMethodID { get; set; }
        public string MethodType { get; set; }
        public string AccountNumber { get; set; }
        // Otras propiedades del método de pago...
    }

    public class Review
    {
        public int ReviewID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        // Otras propiedades de la reseña...
    }

}
