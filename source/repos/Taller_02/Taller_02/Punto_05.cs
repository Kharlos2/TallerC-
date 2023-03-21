using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_05
    {
        static void Punto_06(string[] args)
        {
            int num = 0, i = 0;
            bool repetidos = false;
            int[] vectorNumeros = new int[3];

            for (i = 0; i < 3; i++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                vectorNumeros[i] = num;

            }
            for (i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3 - 1; j++)
                {
                    if (i != j && vectorNumeros[i] == vectorNumeros[j])
                    {
                        repetidos = true;
                    }
                }
            }
            if (repetidos)
            {
                Console.WriteLine("Hacen pareja");
            }
        }
    }
}
