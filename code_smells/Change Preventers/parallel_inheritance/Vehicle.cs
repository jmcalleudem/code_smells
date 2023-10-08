using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.parallel_inheritance
{
    // Jerarquía de clases de vehículos
    public class Vehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }
        // Otras propiedades comunes a todos los vehículos...
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        // Propiedades específicas de automóviles...
    }

    public class Motorcycle : Vehicle
    {
        public bool HasHelmetCompartment { get; set; }
        // Propiedades específicas de motocicletas...
    }

    // Jerarquía de clases de motores (paralela a la jerarquía de vehículos)
    public class Engine
    {
        public string EngineModel { get; set; }
        public int Horsepower { get; set; }
        // Otras propiedades comunes a todos los motores...
    }

    public class CarEngine : Engine
    {
        // Propiedades específicas de motores de automóviles...
    }

    public class MotorcycleEngine : Engine
    {
        // Propiedades específicas de motores de motocicletas...
    }

}
