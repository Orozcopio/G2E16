using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G2E2
{
    class Program
    {
        /* 
        16. En una Fábrica de Envases Plásticos se aplica una bonificación del $ 7.00 a los primeros
            500 producidos y el resto $ 001, por cada unidad producida. Diseñe un programa que
            determine el monto a recibir en concepto de bonificación por un obrero en un dia. */
        static void Main(string[] args)
        {
            /**/
            int cantidad;
            int b1=0, b2=0,bt=0;
            cantidad = int.Parse(Console.ReadLine());
            if (cantidad > 500)
            {
                b1 = 7 * 500;
            }
            b2 = cantidad - 500;
            bt = b1 + b2;
            Console.WriteLine("Bonificacion total: " + bt);
            Console.ReadKey();
            /**/

        }
    }
}
