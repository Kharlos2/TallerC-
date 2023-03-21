using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Taller_02
{
    internal class Punto_06
    {
        static void Punto6(string[] args) { 
            
            int i = 0;
            int[] vectorNumeros = new int[3];

            for (i = 0; i < 3; i++) {

                Console.Write("Ingrese numero " + (i + 1) + ": ");
                vectorNumeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("RESULTADOS: ");
            for (i = 0; i < 3; i++) {

                if (vectorNumeros[i] % 7 == 0)
                {
                    Console.WriteLine(vectorNumeros[i] + " Es divisible por 7");
                }
                else {
                    Console.WriteLine(vectorNumeros[i] + " No es divisible por 7");
                }

            } 


        }
    }
}
