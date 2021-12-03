using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение длины ребра куба:");
            int a = Convert.ToInt32(Console.ReadLine());
            int S, V;
            GetParam(a, out S, out V);
            Console.WriteLine("Площадь поверхности куба: {0}", S);
            Console.WriteLine("Объём куба: {0}", V);
            Console.ReadKey();
        }
        static void GetParam(int a, out int S, out int V)
        {
            S = a * a * 6;
            V = a * a * a;
        }
    }
}
