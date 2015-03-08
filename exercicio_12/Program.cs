using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12
{
    class Program
    {
        public static double n1, n2, dif;
        static void Main(string[] args)
        {
            Console.WriteLine("informe o primeiro valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("informe o segundo valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            dif = Math.Pow(n1, 2) - Math.Pow(n2, 2);
            Console.WriteLine("a diferença entre eles: " + dif);
            Console.ReadKey();



        }
    }
}
