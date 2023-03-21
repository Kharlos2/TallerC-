using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Class1
    {
        static void Main(string[] args) {

            float num = 0f;


                Console.WriteLine("ingresa tu numero: ");
                num = float.Parse(Console.ReadLine());

            

            if (num == 0)
            {
                Console.WriteLine("el numero es 0");
            }
            else
            {
                if(num < 0)
                {
                    Console.WriteLine("El numero es negativo");

                }
                else
                {
                    Console.WriteLine("el numero es positivo");
                }
            }

            Console.ReadLine();

        }

        
    }
}
