using System;

namespace _1_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задание");
            Console.WriteLine("a*x^2 + b*x + c = 0");

            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;
          
           Console.WriteLine("D = " + D);

            while (true)
            {
                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("x1 =" + x1);
                    Console.WriteLine("x2" + x2);
                    break;
                }
                else if (D == 0)
                {
                    double x1 = -b / 2 * a;
                    Console.WriteLine("x1 =" + x1);
                    break;
                }
                else if (D < 0)
                {
                    Console.WriteLine("Дискриминант меньше 0, а значит не имеет корней! Но у нас есть другое задание, поэтому...");
                    Console.Write("x = ");
                    int x = Convert.ToInt32(Console.ReadLine());

                    Console.Write("i = ");
                    int i = Convert.ToInt32(Console.ReadLine());

                    Console.Write("y = ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    // Решение

                    double x1 = x + i * y;

                    double x2 = x - i * y;
                    Console.WriteLine("1 комплексное число" + x1);
                    Console.WriteLine("2 комплексное число" + x2);
                    break;
                }
            }
                Console.ReadKey();
        }
        
    }
}
