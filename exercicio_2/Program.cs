using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    class Program
    {
        public static double C, F;
        static void Main(string[] args)
        {
            Console.WriteLine("informe a temperatura em Fahrenheit ");
            C = Convert.ToDouble(Console.ReadLine());

            F = ((C - 32) * (5 / 9));
            

            Console.WriteLine("os graus em celsius é: " +F);
            Console.ReadKey();
        }
    }
}
