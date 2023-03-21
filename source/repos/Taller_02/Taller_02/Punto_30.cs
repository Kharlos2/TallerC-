using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_30
    {
        static void Main(string[] args)
        {
            int eleccion = 0, t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0, t6 = 0;

            for (int i = 1; i <= 200; i++)
            {
                eleccion = eleccionT();

                switch (eleccion)
                {
                    case 1: t1++; break;
                    case 2: t2++; break;
                    case 3: t3++; break;
                    case 4: t4++; break;
                    case 5: t5++; break;
                    case 6: t6++; break;
                }

            }
            Console.WriteLine("se vendieron " + t1 + " tiquetes para Medellín - Miami.");
            Console.WriteLine("se vendieron " + t2 + " tiquetes para Medellín – Bogotá - Roma.");
            Console.WriteLine("se vendieron " + t3 + " tiquetes para Medellín – Panamá- Los Ángeles.");
            Console.WriteLine("se vendieron " + t4 + " tiquetes para Medellín – Bogotá - Madrid.");
            Console.WriteLine("se vendieron " + t5 + " tiquetes para Medellín – Miami – Toronto.");
            Console.WriteLine("se vendieron " + t6 + " tiquetes para Medellín – Buenos Aires.");
        }
        static int eleccionT()
        {
            int opcion = 0 ;
            do
            {
                Console.WriteLine("Elija tiquete\n1 -  Medellín - Miami.\n2 - Medellín – Bogotá - Roma.\n3 - Medellín – Panamá- Los Ángeles.\n4 -  Medellín – Bogotá - Madrid.");
                Console.WriteLine("5 -  Medellín – Miami –Toronto.\n6 -   Medellín – Buenos Aires.");
                opcion = int.Parse(Console.ReadLine());

            } while (opcion < 0 || opcion > 6);
            return opcion;
        }
    }
}
