using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccionesDeVehiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Bienvenidos al mantenimiento de transportes");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            //Creo una instancia de la clase Coche, en donde la variable miCoche almacena los metodos de la clase Coche.
            Vehiculo miCoche = new Coche();

            miCoche.RealizarMantenimiento();

            Console.WriteLine("Costo del mantenimiento del coche: " + miCoche.ObtenerCostoMantenimiento());
            Console.WriteLine();


            //Creo una instancia de la clase Moto, en donde la variable miMoto almacena los metodos de la clase Moto.
            Vehiculo miMoto = new Moto();

            miMoto.RealizarMantenimiento();

            Console.WriteLine("Costo del mantenimiento de la moto: " + miMoto.ObtenerCostoMantenimiento());
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();


            //Mando a llamar al metodo lavar.

            //Este metodo esta oculto en la clase Coche, por lo tanto mostrara el metodo de la clase base.
            miCoche.Lavar();
            Console.WriteLine();


            //Creamos una intancia solamente de la clase Coche, para tener acceso al metodo oculto.
            Coche miCocheReal = new Coche();

            miCocheReal.Lavar();
            Console.WriteLine();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();


            //Creo una instancia de la clase CambioAceite, en donde la variable servicioAceite almacena los metodos de la clase CambioAceite.
            Servicio servicioAceite = new CambioAceite();

            servicioAceite.RealizarServicio();

            Console.WriteLine("Costo del cambio de aceite $: " + servicioAceite.CalcularCosto());
            Console.WriteLine();

            //Creo una instancia de la clase ReparacionFrenos, en donde la variable servicioFrenos almacena los metodos de la clase ReparacionFrenos.
            Servicio servicioFrenos = new ReparacionFrenos();

            servicioFrenos.RealizarServicio();

            Console.WriteLine("Costo de la reparacion de frenos $: " + servicioFrenos.CalcularCosto());
            Console.WriteLine();

            //No podemos instanciar la clase Servicio ya que es una clase abstracta.
            //Servicio mensajero = new Servicio();



        }
    }
}
