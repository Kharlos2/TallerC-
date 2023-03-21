using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_29
    {
        static void Punto29(string[] args)
        {
            int cantidadImpares = 0, opcion = 0, i = 0, num = 0, numMayor = 0, veces = 0;
            bool control = true, existe = false;

            while(control)
            {
                Console.WriteLine("Ingrese numero: ");
                num = int.Parse(Console.ReadLine());
                if (num > numMayor)
                { 
                    veces++;
                    numMayor = num;
                }
                i++;
                if(num % 2 == 0) cantidadImpares++;
                if (num % 7 == 0) existe = true;
                Console.WriteLine("¿Desea seguir ingresando numeros?\n1 - Si, Cualquier otro - No");
                opcion = int.Parse(Console.ReadLine());
                if (opcion != 1) control = false;
            }

            Console.WriteLine("El numero mayor es: " + numMayor + " fue hallado " + veces + " veces");
            Console.WriteLine("El porcentaje de numeros impares es: " + ((cantidadImpares * 100)/i));
            if (existe)
            {
                Console.WriteLine("Existe numero multiplo de 7");
            }

        }
    }
}
