using System;

namespace _6_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 задание");

            Console.WriteLine("Введите число от 1 до 100");           
            int i = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (i < 101 && i > 0)
                {
                    if (i == 1 | i == 21 | i == 31 | i == 41 | i == 51 | i == 61 | i == 71 | i == 81 | i == 91)
                    {
                        Console.WriteLine(i + " год");
                        break;
                    }
                    else if (i > 1 & i < 5 | i > 21 & i < 25 | i > 31 & i < 35 | i > 41 & i < 45 | i > 51 & i < 55 | i > 62 & i < 65 | i > 71 & i < 75 | i > 81 & i < 85 | i > 91 & i < 95)              
                    {
                        Console.WriteLine(i + " года");
                        break;
                    }
                    else if(i>5 & i<21 | i>24 & i<31 | i>34 & i<41 | i>44 & i<51 | i>54 & i<61 | i>64 & i<71 | i>74 & i<81 | i>84 & i < 91 | i>94 & i<101)
                    {
                        Console.WriteLine(i + " лет");
                        break;
                    }
                                          
                }
                else
                {
                    Console.WriteLine("Русским же языком написал. От 1 до 100");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
