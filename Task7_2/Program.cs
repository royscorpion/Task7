using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double V, S;
            CalcCubeVolume_n_Area(a, out V, out S);
            Console.WriteLine("Площадь поверхности куба: {0}\nОбъем куба: {1}",S,V);
            Console.ReadKey();
        }
        static void CalcCubeVolume_n_Area(double a, out double V, out double S)
        {
            V = a*a*a;
            S = 6*a*a;
        }
    }
}
