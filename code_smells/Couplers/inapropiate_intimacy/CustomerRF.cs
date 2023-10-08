using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Couplers.inapropiate_intimacy
{
    public class CustomerRF
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        // Otros campos y propiedades...

        public void SendConfirmationEmail()
        {
            // Lógica para enviar un correo de confirmación al cliente
            string subject = "Confirmación de pedido";
            string body = $"Estimado {Name}, su pedido ha sido confirmado.";
            EmailServiceRF.SendEmail(Email, subject, body);
        }
    }
    public class EmailServiceRF
    {
        public static void SendEmail(string email, string subject, string body) { }
    }
    public class OrderRF
    {
        public CustomerRF Customer { get; set; }
        public List<Product> Products { get; set; }

        public void SendConfirmationEmail()
        {
            Customer.SendConfirmationEmail();
        }
    }

    public class ProductRF
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

}
