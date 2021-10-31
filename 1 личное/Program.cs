using System;

namespace _1_личное
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Ввидите день:");
            int day = Convert.ToInt32(Console.ReadLine());
            while(true)
            if (day > 31)
            {
                 Console.WriteLine("Максимальное кол-во дней в месяце 31!");
                 break;
            }
            else if (day > 0 | day < 9 )
            {
                    //нужно сделать 0 + день!
                    Console.Write("Введите месяц:");
                    int month = Convert.ToInt32(Console.ReadLine());
                    while (true)
                        if (month > 12)
                        {
                            Console.WriteLine("В году 12 месяцев!");
                            break;
                        }else if (month > 0 | month < 9)
                        {
                            // 0 + месяц!
                            Console.Write("Введите год:");
                            int year = Convert.ToInt32(Console.ReadLine());
                            while (true)
                                if (year > 2021)
                                {
                                    Console.WriteLine("Будущее еще не наступило...");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("0" + day + "/" + "0" + month + "/" + year);
                                    break;
                                }
                            break;
                        }
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
