using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_13
    {
        static void Main(string[] args)
        {
            float num = 0f, aux = 0f;
            Console.WriteLine("Digite un numero: ");
            num = float.Parse(Console.ReadLine());
            if(num >= 0)
            {
                aux = num * -1;
                Console.Write("el numero es positivo, asi que negativo es: " + aux);
            }
            else
            {
                aux = num * -1;
                Console.Write("el numero es negativo, asi que positivo es: " + aux);
            }

            Console.ReadLine();
        }
        }
}
