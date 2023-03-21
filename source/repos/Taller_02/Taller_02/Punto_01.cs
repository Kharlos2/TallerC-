using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_01
    {
        static void Punto1(string[] args)
        {
            Console.Write("Ingrese primer numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(validacionDivision(n1,n2));
            Console.ReadKey();
        }
        static string validacionDivision(int n1, int n2) {
            string mensaje = "";
            if (n2 == 0)
            {
                mensaje = "No es posible";
            }
            else if (n2 != 0)
            {
                decimal div = Convert.ToDecimal(n1) / Convert.ToDecimal(n2);
                
                mensaje = $"el resultado es: {div}";
            }
            return mensaje;
        }
    }
}
