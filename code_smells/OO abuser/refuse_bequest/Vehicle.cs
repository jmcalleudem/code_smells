using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.refuse_bequest
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public void Start()
        {
            // Lógica para arrancar el vehículo
        }

        public void Stop()
        {
            // Lógica para detener el vehículo
        }

        public void OpenTrunk()
        {
            // Lógica para abrir el maletero
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public void OpenTrunk()
        {
            // Lógica para abrir el maletero
        }
    }

    public class Motorcycle : Vehicle
    {
        public bool HasHelmetCompartment { get; set; }
        public void Wheelie()
        {
            // Lógica para hacer un caballito con la motocicleta
        }
    }

}
