using System;

namespace Task1_1
{
    class Program
    {
        static void Main()
        {
            double n;
            double x;
            Console.Write("Степень корня n: ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.Write("Извлечь из числа x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Корень {n} степени из {x} равен:\t{Sqrt(x, n)}");
            Console.WriteLine($"Результат метода Math.Pow:\t{Math.Pow(x, 1 / n)}");

            Console.ReadKey();
        }

        static double Sqrt(double x, double n)
        {
            double eps = 0.0001;
            double x0 = x / n;
            double x1 = (1 / n) * ((n - 1) * x0 + x / Pow(x0, (int)n - 1));
            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + x / Pow(x0, (int)n - 1));
            }
            return x1;
        }

        static double Pow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= a;
            }
            return result;
        }
    }
}
