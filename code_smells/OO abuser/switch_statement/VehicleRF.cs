using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.switch_statement
{
    public abstract class VehicleRF
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        // Otras propiedades comunes a todos los vehículos...

        public abstract void Start();

        // Otros métodos comunes a todos los vehículos...
    }

    public class CarRF : VehicleRF
    {
        public override void Start()
        {
            // Lógica específica para arrancar un automóvil...
        }

        // Propiedades y métodos específicos para automóviles...
    }

    public class MotorcycleRF : VehicleRF
    {
        public override void Start()
        {
            // Lógica específica para arrancar una motocicleta...
        }

        // Propiedades y métodos específicos para motocicletas...
    }

    public class BicycleRF : VehicleRF
    {
        public override void Start()
        {
            // Lógica específica para comenzar a pedalear en una bicicleta...
        }

        // Propiedades y métodos específicos para bicicletas...
    }

}
