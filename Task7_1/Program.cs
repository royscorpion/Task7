using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Определение треугольника с максимальной площадью из двух с заданными сторонами, используя метод для вычисления площади треугольника по длинам его сторон
            #region Ввод исходных данных
            Console.WriteLine("Введите последовательно стороны первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите последовательно стороны второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            #endregion
            double S1, S2;
            Console.WriteLine("Максимальная площадь у {0} треугольника со сторонами {1} x {2} x {3}\nS = {4:f2} квадратных единиц",
                (S1 = CalcAreaTriangles(x1, y1, z1)) > (S2 = CalcAreaTriangles(x2, y2, z2))?"первого":"второго", S1 > S2 ? x1:x2, S1 > S2 ? y1 : y2, S1 > S2 ? z1 : z2, S1 > S2 ? S1 : S2);
            Console.ReadKey();
        }

        // ********************************************************************
        // **** Метод вычисления площади треугольника по длинам его сторон ****
        // ********************************************************************
        
        static double CalcAreaTriangles(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
    }
}
