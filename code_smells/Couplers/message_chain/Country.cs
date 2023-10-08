using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Couplers.message_chain
{
    public class Country
    {
        public string Name { get; set; }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public Country Country { get; set; }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public string GetCustomerCountryName()
        {
            // Accediendo a través de múltiples objetos para obtener el nombre del país
            if (Address != null && Address.Country != null)
            {
                return Address.Country.Name;
            }
            return "Desconocido";
        }
    }

    public class Main
    {
        public static void main(string[] args)
        {
            // Uso del código
            var customer = new Customer
            {
                FirstName = "John",
                LastName = "Doe",
                Address = new Address
                {
                    Street = "123 Main St",
                    City = "Cityville",
                    Country = new Country
                    {
                        Name = "United States"
                    }
                }
            };

            string countryName = customer.GetCustomerCountryName();
            Console.WriteLine($"El cliente vive en {countryName}");
        }
    }

}
