using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_28
    {
        static void Punto28(string[] args)
        {
            int numerosPares = 0;
            for(int i = -15; i <= 2000; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                    numerosPares++;
                }
            }
            Console.WriteLine("Hay " + numerosPares + " numeros pares entre -15 y 2000");
        }

    }
}
