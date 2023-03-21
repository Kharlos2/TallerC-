using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_26
    {
        static void Punto26(string[] args)
        {
            int numero = 0, opcion = 0;
            bool control = true;
            while (control)
            {
                numero = validarNumero();
                Console.WriteLine(funcionPrimos(numero));
                Console.WriteLine("¿Desea seguir ingresando numeros?\n1 - Si, Cualquier otro - No");
                opcion = int.Parse(Console.ReadLine());
                if (opcion != 1) control = false;
            }
        }
        static int validarNumero() 
        {
            int _numero = 0;
            do
            {
                Console.WriteLine("Ingrese numero: ");
                _numero = int.Parse(Console.ReadLine());
            } while (_numero < 0);
            return _numero;
        }
        static string funcionPrimos(int _numero)
        {
            int veces = 0;

            for (int i = 1; i <= _numero; i++)
            {

                if (_numero % i == 0) veces++;

            }
            if (veces <= 2)
            {
                return _numero + " Es primo";
            }
            else 
            {
                return _numero + " No es primo";
            }
        }

    }
}
