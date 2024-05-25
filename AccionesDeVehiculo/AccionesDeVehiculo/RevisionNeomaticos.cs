using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccionesDeVehiculo
{
    public class RevisionNeomaticos : Servicio
    {

        //Implementacion de los metodos de la clase abstracta.

        //La palabra reservada override nos ayuda hacer una nueva implementacion de los metodos abstracto.

        public override void RealizarServicio()
        {

            Console.WriteLine("Realizando revision de neomaticos.");

        }

        public override double CalcularCosto()
        {

            return 50.0;  //Este es el costo de la revision de llantas.

        }

        public override int TiempoDeServicio()
        {

            return 2; //Este es el tiempo en el que se realiza una revision de neomaticos.

        }

    }

}
