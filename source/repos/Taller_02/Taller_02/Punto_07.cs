using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_07
    {
        static void Punto7(string[] args) {

            int edad = 0, cedula = 0;
            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su numero de cédula: ");
            cedula = int.Parse(Console.ReadLine());

            Console.WriteLine("RESULTADO: ");
            Console.WriteLine(validacionVoto(edad, cedula));
        }
        static string validacionVoto(int _edad , int _cedula) {

            if (_edad < 18)
            {
                return "No puede votar";
            }
            else { 
                return "Cedula: "+ _cedula; 
            }

        }
    }
}
