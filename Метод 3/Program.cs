using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Метод_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());            
            CalcSum(ref a, b);
            Console.WriteLine(a);
            Console.ReadKey();
        }
        static void CalcSum(ref int a, int b)
        {
            a += b;
        }
    }
}
