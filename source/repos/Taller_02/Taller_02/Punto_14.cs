using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_14
    {
        static void Main(string[] args)
        {
            float preciohora = 1000f, valorhora = 0f, valorhora1 = 0f, descuento =0f, porcentaje = 0.20f, precio = 0f ;
            int horas = 0, aux = 0;
            Console.WriteLine("ALQUILER DE AUTOS EL PANOCHON");
            Console.WriteLine("VALOR POR HORA: " + preciohora + "$");
            Console.WriteLine("digite las horas que se uso el parqueadero: ");
            horas = int.Parse(Console.ReadLine());
            descuento = preciohora * porcentaje;
            precio = preciohora - descuento;


            if (horas > 10){
                aux = horas - 10;
                valorhora = (aux * precio) + (preciohora * 10);
                Console.WriteLine("el precio total es de: " + valorhora);
            }
            else
            {
                valorhora = preciohora * horas;
                Console.WriteLine("el precio total es de: " + valorhora);
            }


            Console.ReadKey();

        }
        }
}
