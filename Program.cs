﻿using System;

namespace HelloWorld
{

    internal class Program
    {
        
        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }
            static void Main(string[] args)
        {
            int i = 100;
            Console.WriteLine(i);

            ChangeValue(i);

            Console.WriteLine();
            Console.Read();

        }
                }
        }


