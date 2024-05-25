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
            string tipoDeTranporte;
            int horaTotalDeServicio;
            string lavarTranporte;
            double pagoTotal;


            //IMPLEMENTACION DE LA GUIA


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


            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();


            //IMPLEMENTACION NUEVA DEL METODO INDEPENDIENTE


            Console.WriteLine("***************************");
            Console.WriteLine("* Servicios de tranportes *");
            Console.WriteLine("*        ---Menu---       *");
            Console.WriteLine("*          Coche          *");
            Console.WriteLine("*          Moto           *");
            Console.WriteLine("***************************");

            Console.Write("Elija el tipo de transporte: ");
            tipoDeTranporte = Console.ReadLine();
            Console.WriteLine();

            if (tipoDeTranporte == "Coche")
            {

                miCoche.RealizarMantenimiento();
                Console.WriteLine();

                Console.WriteLine("Total de hora del cambio de aceite: " + servicioAceite.TiempoDeServicio());
                Console.WriteLine("Total de hora de reparacion de frenos: " + servicioFrenos.TiempoDeServicio());

                horaTotalDeServicio = servicioAceite.TiempoDeServicio() + servicioFrenos.TiempoDeServicio();

                Console.WriteLine("Tiempo total del servicio del coche: " + horaTotalDeServicio);
                Console.WriteLine();

                Console.Write("¿Desea lavar el coche?:  ");
                lavarTranporte = Console.ReadLine();
                Console.WriteLine();

                if (lavarTranporte == "si")
                {

                    miCocheReal.Lavar();
                    Console.WriteLine();

                    Console.WriteLine("Total de hora para lavar: " + miCoche.TiempoLavar());

                    horaTotalDeServicio += miCoche.TiempoLavar();

                    Console.WriteLine("Tiempo total del servicio del coche: " + horaTotalDeServicio);
                    Console.WriteLine();

                    pagoTotal = miCoche.ObtenerCostoMantenimiento() + miCoche.ObtenerCostoLavado();

                    Console.WriteLine("Total a pagar de los servicios del coche: " + pagoTotal);
                    Console.WriteLine();

                }
                else if (lavarTranporte == "no")
                {

                    pagoTotal = miCoche.ObtenerCostoMantenimiento();

                    Console.WriteLine("Total a pagar de los servicios del coche: " + pagoTotal);

                }

            }
            else if (tipoDeTranporte == "Moto")
            {

                miMoto.RealizarMantenimiento();
                Console.WriteLine();

                Servicio servicioLubricante = new LubricacionCadena();
                Servicio servicioNeomaticos = new RevisionNeomaticos();

                Console.WriteLine("Total de hora de lubricacion de cadena: " + servicioLubricante.TiempoDeServicio());
                Console.WriteLine("Total de hora de revision de neumaticos: " + servicioNeomaticos.TiempoDeServicio());

                horaTotalDeServicio = servicioLubricante.TiempoDeServicio() + servicioNeomaticos.TiempoDeServicio();

                Console.WriteLine("Tiempo total del servicio de la moto: " + horaTotalDeServicio);
                Console.WriteLine();

                Console.Write("¿Desea lavar la moto?:  ");
                lavarTranporte = Console.ReadLine();
                Console.WriteLine();

                if (lavarTranporte == "si")
                {

                    Moto miMotoReal = new Moto();

                    miMotoReal.Lavar();
                    Console.WriteLine();

                    Console.WriteLine("Total de hora para lavar: " + miMoto.TiempoLavar());

                    horaTotalDeServicio += miMoto.TiempoLavar();

                    Console.WriteLine("Tiempo total del servicio de la moto: " + horaTotalDeServicio);
                    Console.WriteLine();

                    pagoTotal = miMoto.ObtenerCostoMantenimiento() + miMoto.ObtenerCostoLavado();

                    Console.WriteLine("Total a pagar de los servicios de la moto: " + pagoTotal);
                    Console.WriteLine();


                }
                else if(lavarTranporte == "no")
{
                    pagoTotal = miMoto.ObtenerCostoMantenimiento();

                    Console.WriteLine("Total a pagar de los servicios de la moto: " + pagoTotal);

                }

            }

        }

    }

}
