using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_04
    {
        static void Punto4(string[] args)
        {
            int final = numeroMayor();
            Console.WriteLine("El numero mayor es: " + final);
        }
        static int numeroMayor()
        {
            int mayor = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese numero " + (i + 1) + ": ");
                int num = int.Parse(Console.ReadLine());
                if (num > mayor)
                {
                    mayor = num;
                }
            }
            return mayor;
        }
    }
}
