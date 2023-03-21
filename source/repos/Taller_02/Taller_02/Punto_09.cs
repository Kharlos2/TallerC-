using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Taller_02
{
    internal class Punto_09
    {
        static void Punto9(string[] args)
        {
            string nombre = "";
            int edad = 0, estadoCivil = 0, genero = 0;
            Console.Write("Ingrese Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());
            estadoCivil = validacionEstadoCivil();
            genero = validacionGenero();
            Console.WriteLine("***Resultado***\n" + proceso(nombre, edad, estadoCivil, genero));
        }
        static int validacionEstadoCivil() {
            int _estadoCivil = 0;
            do
            {
                Console.WriteLine("Ingrese estado civil\n1 - Casado\n2 - Union libre\n3 - Soltero");
                Console.Write("Respuesta: ");
                _estadoCivil = int.Parse(Console.ReadLine());

            } while (_estadoCivil < 1 || _estadoCivil > 3);
            return _estadoCivil;

        }
        static int validacionGenero()
        {
            int _genero = 0;
            do
            {
                Console.WriteLine("Ingrese su genero\n1 - Hombre\n2 - Mujer");
                _genero = int.Parse(Console.ReadLine());
            } while (_genero < 1 || _genero > 2);
            return _genero;
        }
        static string proceso(string _nombre, int _edad, int _estadoCivil, int _genero)
        {
            if (_edad >= 18 && _genero == 2 && _estadoCivil == 1)
            {
                return $"Nombre: {_nombre}\nEdad: {_edad}";
            }
            else if (_genero == 1 && _estadoCivil == 3) 
            {
                return $"Nombre: {_nombre}";
            }
            else { return "No cumple con lo pedido"; }
        }
    }
}
