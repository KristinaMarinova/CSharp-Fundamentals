﻿namespace P06.StrongNumber
{
    using System;
    class Startup
    {
        public static void Main()
        {

            int s1 = 0;

            int n = int.Parse(Console.ReadLine());
            int n1 = n;

            for (int j = n; j > 0; j = j / 10)
            {
                int fact = 1;
                for (int i = 1; i <= j % 10; i++)
                {
                    fact = fact * i;
                }
                s1 = s1 + fact;
            }

            if (s1 == n1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}