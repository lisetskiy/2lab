using System;

namespace _2_личное
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a < b");
            
            Console.Write("a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            while(true)
                if (a > b | a == b)
                {
                    Console.WriteLine("Ошибка.Введите a < b");
                    break;
                }
                else if (a < 0 | b < 0)
                {
                    Console.WriteLine("a и b должно быть больше 0 !");
                }
                else if ((a % 2) == 1)
                {
                    int sum = 0;
                    for (int i = a; i <=b; i +=2)
                    {                      
                        sum += i;                      
                    }
                    Console.WriteLine(sum);
                    break;
                }else if ((a % 2) != 1)
                {
                    a += 1;
                    int sum = 0;
                    for (int i = a; i <= b; i += 2)
                    {                                                                     
                        sum +=i;                                                                
                    }
                    Console.WriteLine(sum);
                    break;
                }              
            Console.ReadKey();            
        }
    }
}
