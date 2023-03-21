using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercico_12
    {
        static void Main(string[] args) {

            float num = 0f, num1 = 0f;

            Console.Write("Digite el primer numero: ");
            num = float.Parse(Console.ReadLine());
            Console.Write("Digite el segundo numero: ");
            num1 = float.Parse(Console.ReadLine());

            if(num > 0 || num1 > 0)
            {
                Console.WriteLine(num);
                Console.WriteLine(num1);

            }
            else
            {
                Console.WriteLine("niguno de los dos numero es positivo");
            }
            Console.ReadKey();







        }
    }
}
