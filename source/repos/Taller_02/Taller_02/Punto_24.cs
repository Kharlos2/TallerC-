using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_24
    {
        static void Punto24(string[] args)
        {
            decimal nota = 0, notaAlta = 0, acomulador = 0;
            int campeones = 0, noCampeones = 0;
            string nombre = "";

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Ingrese nombre del estudiante: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el la nota del estudiante " + (i + 1) + ": ");
                nota = validarNota();
                if (nota > notaAlta) notaAlta = nota;
                acomulador += nota;
                if (nota >= 3) campeones++;
                else noCampeones++;
                Console.WriteLine(nombre + mensaje(nota));
            }
            Console.WriteLine("La calificación mas alta es: " + notaAlta);
            Console.WriteLine("El promedio fue de: " + (acomulador/100));
            Console.WriteLine(campeones + " estudiantes ganaron la materia");
            Console.WriteLine(noCampeones + " estudiantes perdieron la materia");
        }
        static decimal validarNota()
        {
            decimal _nota = 0;
            do
            {
                _nota = decimal.Parse(Console.ReadLine());
            }while (_nota < 0 || _nota > 5);
            return _nota;
        }
        static string mensaje(decimal _nota)
        {
            if (_nota >= 3) return " Gano la materia";
            else return " Perdio la materia";
        }
    }
}
