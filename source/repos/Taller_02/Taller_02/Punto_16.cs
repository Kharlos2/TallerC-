using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_16
    {
        static void Main(string[] args)
        {
            float num = 0f, num1 = 0f;
            int banN = 0, baN1 = 0;

            Console.WriteLine("digite el valor del primer digito: ");
            num = float.Parse(Console.ReadLine());
            Console.WriteLine("digite el valor del segundo digito: ");
            num1 = float.Parse(Console.ReadLine());

            if (num > 0)
            {
                banN = 1;
            }

            if (num1 > 0)
            {
                baN1 = 1;
            }


            if (num != 0 && num1 != 0)
            {
                if(banN != baN1)
                {
                    Console.WriteLine(num);
                    Console.WriteLine(num1);
                }
            }

            Console.ReadKey();




        }
    }
}
