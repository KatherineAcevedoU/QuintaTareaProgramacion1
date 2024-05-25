using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccionesDeVehiculo
{
    public class CambioAceite : Servicio
    {

        //Implementacion de los metodos de la clase abstracta.

        //La palabra reservada override nos ayuda hacer una nueva implementacion de los metodos abstracto.

        public override void RealizarServicio()
        {

            Console.WriteLine("Realizando cambio de aceite.");

        }

        public override double CalcularCosto()
        {

            return 50.0;  //Este es el costo del cambio de aceite.
        }

    }
}
