using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller02
{
    internal class Punto_5
    {
        static void Main(string[] args)
        {
            int num = 0, i = 0;
            bool repetidos = false;
            int[] vectorNumeros = new int[3];

            for (i = 0; i < vectorNumeros.Length; i++)
            {

                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                vectorNumeros[i] = num;

            }
            for (i = 0; i < vectorNumeros.Length; i++) { 
                for(int j = 0; j < vectorNumeros.Length- 1; j++)
                {
                    if (i != j && vectorNumeros[i] == vectorNumeros[j]) { 
                       repetidos = true;
                    }
                }
            }
            if (repetidos) {
                Console.WriteLine("Hacen pareja");
            }
        }
    }
}
