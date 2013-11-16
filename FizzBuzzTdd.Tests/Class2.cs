using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTdd.Tests
{
    public class Class2
    {
        public static string GetOutput(int num)
        {
            string output;

            if (num % 3 == 0 && num %5 == 0)
            {
                output = "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                output = "Fizz";
            }
            else if (num % 5 == 0)
            {
                output = "Buzz";
            }
            else
            {
                output = num.ToString();
            }

            return output;
        }
    }
}
