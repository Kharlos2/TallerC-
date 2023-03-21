using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_22
    {
        static void Punto22(string[] args)
        {
            int numero = 0, opcion = 0, cantidadPositivo = 0, cantidadNegativo = 0;
            bool control = true;
            do
            {
                Console.Write("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("¿Desea seguir ingresando numeros?\n1 - Si, Cualquier otro - No");
                opcion = int.Parse(Console.ReadLine());
                if (numero > 0) cantidadPositivo++;
                else cantidadNegativo++;
                if (opcion != 1) control = false;
            } while (control);
            Console.WriteLine("Hay " + cantidadPositivo + " numeros positivos");
            Console.WriteLine("Hay " + cantidadNegativo + " numeros negativos");

        }

    }
}
