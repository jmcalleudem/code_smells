using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_smells.OO_abuser.refuse_bequest
{
    public interface IVehicle
    {
        string Brand { get; set; }
        int Year { get; set; }
        decimal Price { get; set; }
        void Start();
        void Stop();
    }

    public class CarRF : IVehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int NumberOfDoors { get; set; }

        public void Start()
        {
            // Lógica para arrancar el automóvil
        }

        public void Stop()
        {
            // Lógica para detener el automóvil
        }

        public void OpenTrunk()
        {
            // Lógica para abrir el maletero del automóvil
        }
    }

    public class MotorcycleRF : IVehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public bool HasHelmetCompartment { get; set; }

        public void Start()
        {
            // Lógica para arrancar la motocicleta
        }

        public void Stop()
        {
            // Lógica para detener la motocicleta
        }

        public void Wheelie()
        {
            // Lógica para hacer un caballito con la motocicleta
        }
    }

}
