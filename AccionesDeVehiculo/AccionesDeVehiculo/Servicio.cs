using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccionesDeVehiculo
{
    public abstract class Servicio
    {

        //Creamos metodos abstractos que se implementaran en las clases derivadas.
        public abstract void RealizarServicio();

        public abstract double CalcularCosto();

        public abstract int TiempoDeServicio();

    }

}
