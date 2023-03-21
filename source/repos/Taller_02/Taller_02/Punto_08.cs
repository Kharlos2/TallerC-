using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_08
    {
        static void Punto8(string[] args)
        {
            float num = 0, SUM = 0;
            Console.Write("Ingrese un numero: ");
            num = float.Parse(Console.ReadLine());
            if (num >= 0)
            {
                SUM = num + 10;
                Console.WriteLine(SUM);
            }
            else {
                Console.WriteLine(numeroNegativo(num));
            }
        }
        static float numeroNegativo(float _num) {
            return _num * (_num * -1);
        }
    }
}