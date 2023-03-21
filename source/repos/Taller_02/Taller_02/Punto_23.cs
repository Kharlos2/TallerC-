using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_23
    {
        static void Punto23(string[] args)
        {
            int suma = 0;
            for (int i = 1; i < 101; i++) 
            {
                suma += i;
            }
            Console.WriteLine(suma);
            Console.WriteLine("El promedio es: " + (Convert.ToDecimal(suma)/100));
        }

    }
}