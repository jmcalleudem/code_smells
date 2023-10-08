using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.shotgun_surgery
{
    public interface IProduct
    {
        int ProductID { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        // Otros campos comunes...
    }

    public class ProductRF : IProduct
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string SerialNumber { get; set; } // Nuevo campo "Número de serie"
                                                 // Otros campos...
    }

    //inyección de dependencias -- ahora esta clase no depende de producto
    public class InventoryManagerRF 
    {

        public void AddProduct(IProduct product)
        {
            // Lógica para agregar un producto
        }

        public void DeleteProduct(int productID)
        {
            // Lógica para eliminar un producto
        }

        public void UpdateProduct(IProduct product)
        {
            // Lógica para actualizar un producto
        }
    }

}
