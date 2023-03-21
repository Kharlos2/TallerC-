using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_21
    {
        static void Punto21(string[] args) 
        {
            int numero = 0, opcion = 0, cantidad = 0;
            bool control = true;
            do 
            {
                Console.Write("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("¿Desea seguir ingresando numeros?\n1 - Si, Cualquier otro - No");
                opcion = int.Parse(Console.ReadLine());
                if(numero % 3 == 0) cantidad++;
                if (opcion != 1) control = false;
            } while (control);
            Console.WriteLine("Hay " + cantidad + " numeros multiplos de 3");

        }

    }
}