using System;
using System.Linq;
using FizzBuzzLogic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fBLogic = new FBLogic();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fBLogic.GetOutput(i));
            }
            Console.Read();
        }
    }
}
