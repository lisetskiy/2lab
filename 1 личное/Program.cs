using System;

namespace _1_личное
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ввидите день:");
            int day = Convert.ToInt32(Console.ReadLine());

            if (day > 31)
            {
                Console.WriteLine("Максимальное кол-во дней в месяце 31!");
                return;
            }
            else if (day >= 0  | day <= 9)
            {
                // 0 + день!
                Console.Write("Введите месяц:");
                int month = Convert.ToInt32(Console.ReadLine());
                if (month > 12)
                {
                    Console.WriteLine("В году 12 месяцев!");
                    return;
                }
                else if (month >= 0 | month <= 9)
                {
                    // 0 + месяц!
                    Console.Write("Введите год:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    if (year > 2021)
                    {
                        Console.WriteLine("Будущее еще не наступило...");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("0" + day + "/" + "0" + month + "/" + year);
                    }
                }
                else if (month >= 10 | month <= 12)
                {
                    Console.Write("Введите год:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    if (year > 2021)
                    {
                        Console.WriteLine("Будущее еще не наступило...");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("0" + day + "/" + month + "/" + year);
                    }
                }
            }
            else if ( day >= 10 | day <= 31 )
            {
                Console.Write("Введите месяц:");
                int mon = Convert.ToInt32(Console.ReadLine());
                if (mon > 12)
                {
                    Console.WriteLine("В году 12 месяцев!");
                }
                else if (mon >= 10 | mon <= 12)
                {
                    Console.Write("Введите год:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    if (year > 2021)
                    {
                        Console.WriteLine("Будущее еще не наступило...");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(day + "/" + mon + "/" + year);
                    }
                }
                else if (mon >= 0 | mon <= 9)
                {
                    // 0 + месяц!
                    Console.Write("Введите год:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    if (year > 2021)
                    {
                        Console.WriteLine("Будущее еще не наступило...");
                        return;
                    }
                    else
                    {
                        Console.WriteLine(day + "/" + "0" + mon + "/" + year);
                    }
                }
            }
        }
    }
}
