﻿using System;

namespace _3_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            //3 задание
            int perv = 1;
            int vtor = 1;
            int sum = 0;
            while(sum < 9999)
            {
                sum = perv + vtor;

                perv = vtor;

                vtor = sum;
                if (sum > 1000 & sum< 9999)
                {
                    Console.Write("{0} ", sum);
                }              
            } 
            Console.ReadKey();         
        }
    }
}
