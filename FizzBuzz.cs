using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();
        }
    }
    
    class FizzBuzz
    {
        List<string> results = new List<string>();

        public List<string> Results()
        {
            return results;
        }

        public FizzBuzz()
        {
            for(int i = 1; i <= 100; i++)
            {
                results.Add(NumberOrFizzOrBuzzOrFizzBuzz(i));
            }

            PrintResults();
        }

        private string NumberOrFizzOrBuzzOrFizzBuzz(int i)
        {
            if(IsDivisibleByThree(i) && IsDivisibleByFive(i))
            {
                return "FizzBuzz";
            }
            else if(IsDivisibleByThree(i))
            {
                return "Fizz";
            }
            else if(IsDivisibleByFive(i))
            {
                return "Buzz";
            }
            else
            {
                return $"{i}";
            }
        }

        private bool IsDivisibleByThree(int i)
        {
            if(i % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsDivisibleByFive(int i)
        {
            if(i % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PrintResults()
        {
            foreach(string s in results)
            {
                Console.WriteLine(s);
            }
        }
    }
}