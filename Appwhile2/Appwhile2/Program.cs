using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, contado = 1;
            Console.WriteLine("programa valor ingresado");
            Console.WriteLine("digite valor");
            valor = int.Parse(Console.ReadLine());
            while (contado <= valor)
            {
                Console.WriteLine(contado);
                contado++;
            }
            Console.ReadKey();
        }
    }
}
