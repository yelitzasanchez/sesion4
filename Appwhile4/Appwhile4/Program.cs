using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appwhile4
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada = 0, numero = 0, suma = 0, promedio = 0;
            Console.WriteLine("programa suma y promedio");
            while (entrada == 0)
            {
                Console.WriteLine("dijite entrada");
                entrada = int.Parse(Console.ReadLine());
                if (entrada == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("digite entrada");
                    numero = int.Parse(Console.ReadLine());
                    suma = suma + numero;
                    promedio = suma / 10;
                }




            }
            Console.WriteLine("la suma es :" + suma);
            Console.WriteLine("promedio  :" + promedio);
            Console.ReadKey();
        }
    }
}