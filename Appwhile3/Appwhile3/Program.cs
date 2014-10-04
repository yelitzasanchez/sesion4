using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwhile3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 10, numero, suma = 0, promedio = 0, contador = 1;
            Console.WriteLine("programa suma y promedio");

            while (contador <= valor)
            {
                Console.WriteLine("digite valor");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
                contador++;
            }
            promedio = suma / 10;
            Console.WriteLine("la suma es :" + suma);
            Console.WriteLine("promedio  :" + promedio);
            Console.ReadKey();
        }
    }
}
