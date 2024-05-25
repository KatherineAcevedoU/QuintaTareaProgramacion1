using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccionesDeVehiculo
{
    public class Moto : Vehiculo
    {

        //Implementamos los metodos de la clase base.

        //La palabra reservada override nos ayuda hacer una nueva implementacion de los metodos heredados.

        public override void RealizarMantenimiento()
        {

            Console.WriteLine("Realizando mantenimiento de la moto: Lubricacion de cadena y revision de neumaticos.");

        }

        public override double ObtenerCostoMantenimiento()
        {

            return 100.0;  //Este es el costo especifico para el mantenimiento de una moto.

        }


        //Modificamos el nuevo metodo Lavar de la clase base.
        public new void Lavar()
        {

            Console.WriteLine("Lavando la moto con shampoo especial.");

        }

        public override int TiempoLavar()
        {

            return 1; //Este es el tiempo en el que se dilata lavar una moto.

        }

        public override double ObtenerCostoLavado()
        {

            return 100.0; //Este es el costo del lavado de una moto.

        }

    }

}
