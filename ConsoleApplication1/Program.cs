﻿using System;
using System.Linq;
using FizzBuzzLogic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FBLogic.GetOutput(i));
            }
            Console.Read();
        }
    }
}
