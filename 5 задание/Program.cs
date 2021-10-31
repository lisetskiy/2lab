using System;

namespace _5_задание
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //5 задание
            Console.Write("N:");
            int N = Convert.ToInt32(Console.ReadLine());
            int x, y, z;
                                     
            int exam = 0;
            for (x=0,y=0,z=0; x<=N; x++,y++,z++)
            {
               exam = (int)(Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(y, 3));  

                if (exam == N)
                {
                    Console.Write(" x=" + x + " y=" + y + " z=" + z); 
                    return;
                }             
            }
             if (exam != N)
             {
                Console.WriteLine("«No such combinations!»");
             }
            Console.ReadKey();
        }
    }
}
