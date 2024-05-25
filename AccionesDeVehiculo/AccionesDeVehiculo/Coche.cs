using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccionesDeVehiculo
{
    public class Coche : Vehiculo
    {

        //Implementamos los metodos de la clase base.

        //La palabra reservada override nos ayuda hacer una nueva implementacion de los metodos heredados.

        public override void RealizarMantenimiento()
        {

            Console.WriteLine("Realizando mantenimiento del coche: cambio de aceite y revision de frenos.");

        }

        public override double ObtenerCostoMantenimiento()
        {

            return 150.0;  //Este es el costo especifico para el mantenimiento de un coche.

        }

        //Modificamos el nuevo metodo Lavar de la clase base.
        public new void Lavar()
        {

            Console.WriteLine("Lavando el coche con cera y shampoo especial.");

        }

        public override int TiempoLavar()
        {

            return 2; //Este es el tiempo en el que se dilata lavar un coche.

        }

        public override double ObtenerCostoLavado()
        {

            return 200.0; //Este es el costo del lavado de un coche.

        }


    }

}
