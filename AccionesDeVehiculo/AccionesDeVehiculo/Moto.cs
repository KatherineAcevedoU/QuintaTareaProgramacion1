using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccionesDeVehiculo
{
    internal class Moto : Vehiculo
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

    }
}
