using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_19
    {
        static void Main(string[] args)
        {
            int area = 0, metodo = 0;
            float valormetro = 0f, porcen = 0.20f, desc1= 0f, desc2 = 0f, cuotainicial = 0f, total = 0f, aux = 0f, op1 = 0.10f, op2 = 0.8f;


            Console.WriteLine("DIGITE EL AREA DE LA ZONA (EN METROS CUADRADOS)");
            area = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE EL VALOR DE 1 METRO CUADRADO");
            valormetro = int.Parse(Console.ReadLine());

            total = area * valormetro;
            cuotainicial = total * porcen;
            aux = cuotainicial;

            Console.WriteLine("VALOR DE CUOTA INICIAL: "+ cuotainicial);
            Console.WriteLine();
            Console.WriteLine("DIGITE METODO DE PAGO (1 o 2)");
            metodo = int.Parse(Console.ReadLine());

            desc1 = cuotainicial * op1;
            desc2 = cuotainicial * op2;



            switch (metodo)
            {
                case 1:
                    aux = cuotainicial - desc1;
                    Console.WriteLine("EL VALOR FINAL DE SU CUOTA INICIAL ES DE: " + aux);
                    break;
                case 2:
                    aux = cuotainicial - desc2;
                    Console.WriteLine("EL VALOR FINAL DE SU CUOTA INICIAL ES DE: " + aux);
                    break;            
                default:
                    Console.WriteLine("No existe metodo de pago");
                    break;
            }







            Console.ReadKey();
        }
    }
}
