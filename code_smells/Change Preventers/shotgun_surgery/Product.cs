using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.shotgun_surgery
{
    //Un cambio en product requiere cambios en Inventory Manager -- existe alta dependencia entre ambas clases
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        // Otros campos...
    }

    public class ProductCategory
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        // Otros campos...
    }

    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        // Otros campos...
    }

    public class Warehouse
    {
        public int WarehouseID { get; set; }
        public string Location { get; set; }
        // Otros campos...
    }

    public class InventoryManager
    {
        public void AddProduct(Product product)
        {
            // Lógica para agregar un producto
        }

        public void DeleteProduct(int productID)
        {
            // Lógica para eliminar un producto
        }

        public void UpdateProduct(Product product)
        {
            // Lógica para actualizar un producto
        }
    }

}
