﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 500; i <= 525; i++)
            {
                Console.WriteLine(i);
            }

            for (int i =0; i <=100; i +=5)
            {
                Console.WriteLine(i);
            }

            Or 
                
                for  (int i = 0; i<= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
