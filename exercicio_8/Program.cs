using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_8
{
    class Program
    {
        public static double raio, volume, pi=3.1415, result;
        static void Main(string[] args)
        {
            Console.WriteLine("informe o valor do raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            volume = (4 * pi * Math.Pow(raio,3));
            Console.WriteLine("#"+volume);
            result = (volume) /3;
            Console.WriteLine(" o volume da espera eh de :" + result);
            Console.ReadKey();

        }
    }
}
