using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        public static double comprimento, largura, altura;
        public static double volume = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("qual é o comprimento?");
            comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a largura?");
            largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe á altura?");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = comprimento * largura * altura;
            Console.WriteLine(" o volume da caixa é:" + volume);
            Console.ReadKey();
        }
    }
}
