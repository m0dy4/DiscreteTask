﻿using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace project_2
{
 
public class Exercise28
    {
        public static void Main()
        {
            int n, i, sum;
            int mn, mx;
            Console.Write("Enter first number : ");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Perfect numbers between " +mn+" and "+mx+" :");
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.WriteLine(" ");
        }
    }


}
