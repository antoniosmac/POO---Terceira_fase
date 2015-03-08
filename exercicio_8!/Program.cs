using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_8_
{
    class Program
    {
        public static double F, C;
        static void Main(string[] args)
        {
            Console.WriteLine("informe os graus em Fahrenheit: ");
            F = Convert.ToDouble(Console.ReadLine());

            C = (((9 * F) + 160) / 5);
            Console.WriteLine(C);
            Console.ReadKey();
        }
    }
}
