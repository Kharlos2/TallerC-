using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Ejercicio_17
    {
        static void Main(string[] args)
        {
            int codigo = 0, coord = 0, cant = 0, resp = 0, cantotal = 0;
            float total = 0f, valor = 0f, porcentaje = 0.10f, pantalon = 40000f, camiseta= 30000f, interior = 7000f, descuento = 0f, totaldesc = 0f;
            do
            {
                Console.WriteLine("ELIJE UNA OPCION: ");
                Console.WriteLine("1- AGREGAR PRENDA A LA VENTA");
                Console.WriteLine("2- CONSULTAR TIPO DE PRENDA Y VALOR");
                Console.WriteLine("0- TERMINAR");
                coord = int.Parse(Console.ReadLine());
                if(coord == 1)
                {
                    cant = 0;
                    Console.WriteLine("ESCRIBA EL CODIGO DE LA PRENDA");
                    codigo = int.Parse(Console.ReadLine());
                    Console.WriteLine("DIGITE LA CANTIDAD");
                    cant = int.Parse(Console.ReadLine());

                    switch (codigo)
                    {
                        case 1:
                            valor = pantalon * cant;
                            total = total + valor;
                            Console.WriteLine("TOTAL = " + total);
                            Console.WriteLine("");
                            cantotal = cantotal + cant;
                            break;
                        case 2:
                            valor = camiseta * cant;
                            total = total + valor;
                            Console.WriteLine("TOTAL = " + total);
                            Console.WriteLine("");
                            cantotal = cantotal + cant;
                            break;
                        case 3:
                            valor = interior * cant;
                            total = total + valor;
                            Console.WriteLine("TOTAL ACUMULADO = " + total);
                            Console.WriteLine("");
                            cantotal = cantotal + cant;
                            break;
                        default:
                            Console.WriteLine("Codigo no reconocido");
                            Console.WriteLine("");
                            break;
                    }
                }
                if (coord == 2)
                {
                    Console.WriteLine("TIPO DE PRENDA      CODIGO      VALOR");
                    Console.WriteLine("PANTALON               1        40000");
                    Console.WriteLine("CAMISETA               2        30000");
                    Console.WriteLine("INTERIOR               3         7000");
                    Console.WriteLine("");
                }
            } while (coord != 0);


            descuento = total * porcentaje;
            totaldesc = total - descuento;


            if (cantotal > 50)
            {

                Console.WriteLine("AL COMPRAR MAS DE 50 PRODUCTOS TE REGALAMOS EL 10% DE TU COMPRA!!");
                Console.WriteLine("EL VALOR TOTAL DE TU COMPRA ES DE: " + totaldesc + "$");

            }
            else
            {
                Console.WriteLine("EL VALOR TOTAL DE SU COMPRA ES DE: " + total + "$");

            }



            Console.ReadKey();
        }
    }
}
