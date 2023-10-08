using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Bloaters.long_class
{
    public class CustomerRF
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }
        public decimal AccountBalance { get; set; }
        public List<Order> Orders { get; set; }
        public List<PaymentMethod> PaymentMethods { get; set; }
        public List<Review> Reviews { get; set; }

        public CustomerRF()
        {
            Address = new Address();
            Orders = new List<Order>();
            PaymentMethods = new List<PaymentMethod>();
            Reviews = new List<Review>();
        }
    }

    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }

    // Otras clases para Order, PaymentMethod y Review

}
