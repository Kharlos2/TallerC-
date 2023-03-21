using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_25
    {
        static void Punto26(string[] args) 
        {
            int numero1 = 0, numero2 = 1, siguienteNumero, i = 0, suma = 0;
            int[] vector = new int[10];

            for (i = 0; i < 10; i++)
            {
                if (i <= 1) siguienteNumero = i;
                else
                {
                    siguienteNumero = numero1 + numero2;
                    numero1 = numero2;
                    numero2 = siguienteNumero;
                }
                vector[i] += siguienteNumero;
            }
            for (i = 0; i < 10; i++)
            {
                suma += vector[i];
            }
            Console.WriteLine(suma);
        }
    }
}
