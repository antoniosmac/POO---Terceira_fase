using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4
{
    class Program
    {
        public static int nr_coelhos;
        public static double custo;
        static void Main(string[] args)
        {
            Console.WriteLine("informe o numero de coelhos: ");
            nr_coelhos = Convert.ToInt32(Console.ReadLine());

            custo = (nr_coelhos * 0.70) / 28;

            Console.WriteLine("o custo sera de: "+custo);
            Console.ReadKey();
        }
    }
}
