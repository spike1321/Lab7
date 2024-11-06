using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static double Square(int x, int y, int z)
        {
            double p = (x + y + z) / 2;
            double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return s;

        }
        static void Main(string[] args)
        {
            Console.Write("Введите значение x первого треугольника: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите значение y первого треугольника: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Введите значение z первого треугольника: ");
            int z = int.Parse(Console.ReadLine());
            double S = Square(x,y,z);
            Console.Write("Введите значение x второго треугольника: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение y второго треугольника: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение z второго треугольника: ");
            int z1 = int.Parse(Console.ReadLine());
            double S1 = Square(x1, y1, z1);
            if (!double.IsNaN(S) && !double.IsNaN(S1))
            {
                Console.WriteLine("Площадь первого треуголника: {0:00.00}", S);
                Console.WriteLine("Площадь второго треуголника: {0:00.00}", S1);
                if (S > S1)
                {
                    Console.WriteLine("Площадь первого треуголника больше второго");
                }
                else if (S < S1)
                {
                    Console.WriteLine("Площадь второго треуголника больше первого");
                }
                else
                {
                    Console.WriteLine("Площадь первого треуголника равна площади второго");
                }
            }
            else
            {
                Console.WriteLine("Некорректно заданны длины сторон.");
            }
            
            Console.ReadKey();
        }
    }
}
