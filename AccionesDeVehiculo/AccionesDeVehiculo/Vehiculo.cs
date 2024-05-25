using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccionesDeVehiculo
{
    internal class Vehiculo
    {

        //Creamos metodos virtuales en la clase base.

        //La palabra reservada virtual se utiliza para especificar al metodo que se volvera a definir en clases derivadas.
        public virtual void RealizarMantenimiento()
        {

            Console.WriteLine("Realizando mantenimiento general del vehiculo.");

        }

        public virtual double ObtenerCostoMantenimiento()
        {

            return 50.0;  //Este es el costo del mantenimiento general.

        }


        //Nuevo metodo llamado Lavar
        public void Lavar()
        {

            Console.WriteLine("Lavando el vehiculo.");

        }


    }
}
