using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class Program
    {
        public static double areab, pi=3.1415, raio;
        public static double volume, altura;
        static void Main(string[] args)
        {
            Console.WriteLine("informe o valor do raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            areab = pi * raio * raio;
            Console.WriteLine("area base do cilindro: " + areab);

            Console.WriteLine("informe a altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = areab * altura;
            Console.WriteLine("o volume do cilindro: " + volume);
            Console.ReadKey();




        }
    }
}
