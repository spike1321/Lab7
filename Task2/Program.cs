using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void GetParamsCube(double a, out double s, out double v)
        {
            s = 6 * Math.Pow(a, 2);
            v = Math.Pow(a, 3);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба: ");
            double edgelength = double.Parse(Console.ReadLine());
            double s;
            double v;
            GetParamsCube(edgelength,out s, out v);
            Console.WriteLine("Площадь куба равна = {0}, объем куба равен = {1}", s,v);
            Console.ReadKey();
        }
    }
}
