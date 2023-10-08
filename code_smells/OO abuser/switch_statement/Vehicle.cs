using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.switch_statement
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        // Otras propiedades comunes a todos los vehículos...

        public void Start()
        {
            switch (Type)
            {
                case "Car":
                    // Lógica para arrancar un automóvil...
                    break;
                case "Motorcycle":
                    // Lógica para arrancar una motocicleta...
                    break;
                case "Bicycle":
                    // Lógica para comenzar a pedalear en una bicicleta...
                    break;
                default:
                    throw new InvalidOperationException("Tipo de vehículo no válido.");
            }
        }

        // Otros métodos comunes a todos los vehículos...
    }

    public class Car : Vehicle
    {
        // Propiedades y métodos específicos para automóviles...
    }

    public class Motorcycle : Vehicle
    {
        // Propiedades y métodos específicos para motocicletas...
    }

    public class Bicycle : Vehicle
    {
        // Propiedades y métodos específicos para bicicletas...
    }

}
