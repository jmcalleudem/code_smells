using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.Couplers.middle_man
{
    public class CustomerRF
    {
        public string Name { get; set; }
    }

    public class OrderRF
    {
        public Customer Customer { get; set; }
        public decimal TotalAmount { get; set; }

        public decimal CalculateDiscount()
        {
            // Lógica para calcular el descuento
            // (Puede depender de varias propiedades del cliente)
            return 10.0m; // Ejemplo simplificado
        }
    }

}
