using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            int num = 0, cuadrado = 0, cubo = 0, operacion = 0;

            Console.Write("digite un numero ENTERO");
            num = int.Parse(Console.ReadLine());
            cuadrado = num * num;
            cubo = num * num * num;
            if (num %2 == 0){
                operacion = cuadrado;
                Console.WriteLine("El numero es par, su cuadrado es: " + operacion);       
            }
            else
            {
                operacion = cubo;
                Console.WriteLine("El numero es impar, su cubo es: " + operacion);
            }



            Console.ReadKey();
        }
    }
}
