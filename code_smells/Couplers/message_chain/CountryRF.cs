using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Couplers.message_chain
{
    public class CountryRF
    {
        public string Name { get; set; }
    }

    public class AddressRF
    {
        public string Street { get; set; }
        public string City { get; set; }
        public CountryRF Country { get; set; }

        public string GetCountryName()
        {
            // Método para obtener el nombre del país
            return Country?.Name ?? "Desconocido";
        }
    }

    public class CustomerRF
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressRF Address { get; set; }

        public string GetCustomerCountryName()
        {
            return Address?.GetCountryName();
        }
    }

    public class MainRF
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
