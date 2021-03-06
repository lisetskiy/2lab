using System;

namespace _4_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: "); double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите q: "); double q = Convert.ToDouble(Console.ReadLine());
            double res = 1;
            double y = (Math.Pow(x, 2) / factorial(2));
            int i = 1;

            while (true)
            {
                if (y >= q)
                {
                    for (i = 1; y >= q; i++)
                    {
                        res = i % 2 == 1 ? res - y : res + y;
                        y = (Math.Pow(x, (2 * i)) / factorial(2 * i));
                    }
                }
                else if(y < q)
                {
                    Console.WriteLine("y < q" + "   " + i);
                    break;
                }
             break;
            }           
            Console.WriteLine("cos(x) = " + res);
            Console.WriteLine("Количество учтенных слагаемых: " + i);
            Console.ReadKey();
        }
        public static double factorial(double i)
        {
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return i * factorial(i - 1);
            }
        }
    }
}