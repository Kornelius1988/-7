using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шаблон
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            double p1, S1;
            {
                p1 = (((double)a1) + ((double)b1) + ((double)c1)) / 2;
                S1 = (Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1)));
                Console.WriteLine(p1);
                Console.WriteLine(S1);
                Console.ReadKey();
            }
        }
    }
}
