using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_15
    {
        static void Main(string[] args)
        {
            float preciohora = 3000f, valorhora = 0f, valorhora1 = 0f, descuento = 0f, porcentaje = 0.35f, precio = 0f;
            int horas = 0, aux = 0, codigoEmp = 0;
            Console.WriteLine("EMPRESA DON NICOLAAAAAAAAAAAAAS");
            Console.WriteLine("SALDO A PAGAR POR HORA: " + preciohora + "$");
            Console.WriteLine("digite digite el codigo del empleado: ");
            codigoEmp = int.Parse(Console.ReadLine());
            Console.WriteLine("digite las horas que trabajó el empleado: ");
            horas = int.Parse(Console.ReadLine());

            descuento = preciohora * porcentaje;
            precio = preciohora + descuento;


            if (horas > 48)
            {
                aux = horas - 48;
                valorhora = (aux * precio) + (preciohora * 48);
                Console.WriteLine("el total a pagar al empleado "+ codigoEmp +  "es de: " + valorhora);
            }
            else
            {
                valorhora = preciohora * horas;
                Console.WriteLine("el total a pagar al empleado " + codigoEmp + " es de: " + valorhora);
            }


            Console.ReadKey();



        }
    }
}
