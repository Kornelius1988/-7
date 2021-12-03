using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон перого треуголника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины сторон второго треуголника");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            double S1, S2, p1, p2;
            GetParam(a1, b1, c1, a2, b2, c2, out p1, out p2, out S1, out S2);
            if (S1 < S2)
            {
                Console.WriteLine("Площадь второго треугольника больше, чем площадь первого треугольника {0}, {1}", S1, S2);
                Console.ReadKey();
                return;
            }
            if (S1 == S2)
            {
                Console.WriteLine("Площади треугольников равны");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Площадь первого треугольника больше, чем площадь второго треугольника {0}, {1}", S1, S2);
                Console.ReadKey();
            }
        }
        static void GetParam(int a1, int b1, int c1, int a2, int b2, int c2, out double p1, out double p2, out double S1, out double S2)
        {
            p1 = (((double)a1) + ((double)b1) + ((double)c1)) / 2;
            p2 = (((double)a2) + ((double)b2) + ((double)c2)) / 2;
            S1 = Math.Sqrt(p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
            S2 = Math.Sqrt(p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));
        }
    }
}
