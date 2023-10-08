using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.parallel_inheritance
{
    // Jerarquía de clases de vehículos
    public class VehicleRF
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public Engine VehicleEngine { get; set; }
        // Otras propiedades comunes a todos los vehículos...
    }

    public class CarRF : Vehicle
    {
        public int NumberOfDoors { get; set; }
        // Propiedades específicas de automóviles...
    }

    public class MotorcycleRF : Vehicle
    {
        public bool HasHelmetCompartment { get; set; }
        // Propiedades específicas de motocicletas...
    }

    // Clase única de motores con propiedades para ambos tipos de vehículos
    public class EngineRF
    {
        public string EngineModel { get; set; }
        public int Horsepower { get; set; }
        // Otras propiedades comunes a todos los motores...
    }

}
