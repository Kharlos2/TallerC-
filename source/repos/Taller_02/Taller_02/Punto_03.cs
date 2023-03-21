using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02.Puntos
{
    internal class Punto_03
    {
        static void Punto3(string[] args)
        {
            int num1 = 0, num2 = 0, num3 = 0;
            int[] vector;

            Console.Write("Ingrese numero 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero 3: ");
            num3 = int.Parse(Console.ReadLine());
            vector = (int[])ordenNumeros(num1, num2, num3);
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }

        }
        static Array ordenNumeros(int num1, int num2, int num3)
        {

            int[] vectorNum = new int[3];

            if (num1 > num2 && num2 > num3)
            {
                vectorNum[0] = num1;
                vectorNum[1] = num2;
                vectorNum[2] = num3;
                return vectorNum;
            }
            else if (num1 > num3 && num3 > num2)
            {
                vectorNum[0] = num1;
                vectorNum[1] = num3;
                vectorNum[2] = num2;
                return vectorNum;

            }
            else if (num2 > num1 && num1 > num3)
            {
                vectorNum[0] = num2;
                vectorNum[1] = num1;
                vectorNum[2] = num3;
                return vectorNum;

            }
            else if (num2 > num3 && num3 > num1)
            {
                vectorNum[0] = num2;
                vectorNum[1] = num3;
                vectorNum[2] = num1;
                return vectorNum;
            }
            else if (num3 > num2 && num2 > num1)
            {
                vectorNum[0] = num3;
                vectorNum[1] = num2;
                vectorNum[2] = num1;
                return vectorNum;
            }
            else
            {
                vectorNum[0] = num3;
                vectorNum[1] = num1;
                vectorNum[2] = num2;
                return vectorNum;
            }

        }
    }
}
