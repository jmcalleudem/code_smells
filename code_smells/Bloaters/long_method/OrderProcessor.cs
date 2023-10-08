using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Bloaters.long_method
{
    public class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            // Validar la orden
            if (!IsValid(order))
            {
                Console.WriteLine("Orden no válida.");
                return;
            }

            // Lógica Calcular el impuesto
            Console.WriteLine("Calculando impuesto");

            // Lógica Aplicar descuentos
            Console.WriteLine("aplicando impuesto");

            // Lógica Calcular el costo total
            Console.WriteLine("calculando costo total");

            // Lógica Generar la factura
            Console.WriteLine("generandno factura");

            // Lógica Enviar la confirmación por correo electrónico
            Console.WriteLine("enviando email");
        }

        private bool IsValid(Order order)
        {
            // Lógica de validación aquí...
            return true;
        }
    }

    public class Order
    {
        public double TotalPrice { get; set; }
        // Otras propiedades de la orden...
    }

}
