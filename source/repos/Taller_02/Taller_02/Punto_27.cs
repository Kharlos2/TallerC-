using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_27
    {
        static void Punto27(string[] args)
        {
            bool control = true;
            int opcion = 0, i = 0, edad = 0, menorEdad = 0, mayores25 = 0, acumulador = 0;
            decimal porcentaje = 0;
            while (control)
            {
                Console.WriteLine("Ingrese edad de persona No." + (i++ + 1) + ": ");
                edad = int.Parse(Console.ReadLine());
                if (edad > 25) mayores25++;
                if (edad < 18) menorEdad++;
                acumulador += edad;
                Console.WriteLine("¿Desea seguir ingresando personas?\n1 - Si, Cualquier otro - No");
                opcion = int.Parse(Console.ReadLine());
                if (opcion != 1) control = false;
            }
            porcentaje = (menorEdad * 100) / i;
            Console.WriteLine("Hay " + mayores25 + " personas mayores de 25 años");
            Console.WriteLine("Hay " + menorEdad + " personas menores de edad");
            Console.WriteLine("El porcentaje de menores es: " + porcentaje + "%");
            Console.WriteLine("La edad promedio es: " + (acumulador / i));
        }


    }
}
