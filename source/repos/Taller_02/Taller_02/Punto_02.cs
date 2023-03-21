using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_02
    {
        static void Punto2(string[] args)
        {
            Console.WriteLine("INGRESE UN NUMERO: ");
            int num = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine(validarRaiz(num));
        }
        
        static string validarRaiz(int num)
        {
            if (num < 0)
            {
                return "No es posible numero irracional";
            }
            else {
                return $"El resultado es: {Math.Sqrt(num)}";
            }
        }
        
        

    }
}
