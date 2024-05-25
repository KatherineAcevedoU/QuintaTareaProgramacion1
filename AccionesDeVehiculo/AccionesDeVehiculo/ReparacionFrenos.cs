using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccionesDeVehiculo
{
    public class ReparacionFrenos : Servicio
    {

        //Implementacion de los metodos de la clase abstracta.

        //La palabra reservada override nos ayuda hacer una nueva implementacion de los metodos abstracto.

        public override void RealizarServicio()
        {

            Console.WriteLine("Realizando reparacion de frenos.");

        }

        public override double CalcularCosto()
        {

            return 100.0;  //Este es el costo de la reparacion de frenos.

        }

        public override int TiempoDeServicio()
        {

            return 2; //Este es el tiempo en el que se realiza una reparacion de frenos.

        }

    }

}
