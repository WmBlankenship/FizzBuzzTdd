using System;
using System.Linq;

namespace FizzBuzzLogic
{
    public class FBLogic
    {
        public string GetOutput(int num)
        {
            if (num % 3 == 0)
            {
                if (num % 5 == 0)
                {
                    return "FizzBuzz";
                }
                return "Fizz"
            }
            if (num % 5 == 0)
            {
                return "Buzz";
            }
            return num.ToString();
        }
    }
}
