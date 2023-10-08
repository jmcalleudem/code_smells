using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.divergent_change
{
    public class OrderProcessorRF
    {
        public void ProcessOrder(Order order)
        {
            // Lógica para procesar un pedido

            // Ahora, también se encarga de enviar correos electrónicos de confirmación
            EmailService.SendConfirmationEmail(order.CustomerEmail);

            // Además, se encarga de notificar a otros sistemas externos
            ExternalSystemService.NotifyShipping(order.ShippingAddress);

            // Y maneja la generación de facturas
            InvoiceGenerator.GenerateInvoice(order);

            // También realiza un seguimiento de estadísticas internas
            StatisticsService.LogOrderProcessed(order.OrderID);
        }
    }

    public class EmailService
    {
        public static void SendConfirmationEmail(string customerEmail)
        {
            // Lógica para enviar un correo de confirmación
        }
    }

    public class ExternalSystemService
    {
        public static void NotifyShipping(string shippingAddress)
        {
            // Lógica para notificar a sistemas externos
        }
    }

    public class InvoiceGenerator
    {
        public static void GenerateInvoice(Order order)
        {
            // Lógica para generar una factura
        }
    }

    public class StatisticsService
    {
        public static void LogOrderProcessed(int orderID)
        {
            // Lógica para registrar estadísticas de pedidos procesados
        }
    }

    public class Order
    {
        public string CustomerEmail;
        public string ShippingAddress;
        public int OrderID;
    }

}
