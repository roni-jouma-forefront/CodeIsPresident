using System;
using System;

namespace CiPFizzBuzz.Services
{
    public class FizzBuzzService
    {
        public (long fizzCount, long buzzCount) TallyFizzBuzz(long n)
        {
            long fizz = n / 3 - n / 15;
            long buzz = n / 5 - n / 15;
            fizz += n / 15;
            buzz += n / 15;
            return (fizz, buzz);
        }

        public string GetFizzbuzzValue(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            else if (number % 3 == 0)
                return "Fizz";
            else if (number % 5 == 0)
                return "Buzz";
            else
                return number.ToString();
        }
    }
}

