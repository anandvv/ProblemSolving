using System;
using System.Collections.Generic;
using System.Text;

namespace DesignQuestions
{
    class FizzBuzz
    {
        int[] divisors = { 3, 5};

        public FizzBuzz()
        {
        }

        public void runFizzBuzz(int x)
        {
            for(int i=1; i<=x; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i%5 ==0)
                {
                    Console.WriteLine("Buzz");

                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
