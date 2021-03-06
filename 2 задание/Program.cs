using System;

namespace _2_задание
{
    class Program
    {
        static void Main(string[] args)
        {                  
            Console.Write("Задайте точность:");
            double n = Convert.ToDouble(Console.ReadLine());

            double formula = 1, count = 1;
            decimal pi = 1;

            for (int i = 3; formula > n; i += 2)
            {
                formula = 1d / i;
                count = (-1) * formula * Math.Sign(count);
                pi = pi + (decimal)count;
            }
            Console.WriteLine("Значение числа ПИ с точностью " + n + "=" + pi * 4);
            Console.ReadKey();
        }
    }

}