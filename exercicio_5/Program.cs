using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5
{
    class Program
    {
        public static  double KI, KF, Cc, Dp,Gc,DP,CC,GC;
        static void Main(string[] args)
        {
            Console.WriteLine("informe a quilometragem inicial: ");
            KI = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe a quilometragem final: ");
            KF = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("informe o consumo de combustivel: ");
            Cc = Convert.ToDouble(Console.ReadLine());
           Dp = KI - KF;
             Console.WriteLine(" a distancia percorrida: "+Dp);
             GC = (Dp / Cc);
             Console.WriteLine("o gasto de combustivel percorrido " + GC);

             Console.ReadKey();
        }
    }
}
