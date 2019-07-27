using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPrivalia
{
    public static class Fibonacci
    {
        static bool IsPerfectSquare(int value)
        {
            int sqrtResult = (int)Math.Sqrt(value);
            return (sqrtResult * sqrtResult == value);
        }

        public static bool IsFibonacci(int value)
        {
            return IsPerfectSquare(5 * value * value + 4) ||
                   IsPerfectSquare(5 * value * value - 4);
        }

        public static int FindIndexOfFibonacciNumber(int value)
        {
            float indexOfFibonnacciValue = 2.078087F * (float)Math.Log(value) +
                         1.672276F;
            return (int)(Math.Round(indexOfFibonnacciValue));
        }

        public static int FindANumberByLenght(int lenght)
        {
            int value = 1;

            for (int i = 1; i < lenght; i++)
            {
                value = value * 10;
            }

            return value;
        }

        public static int GetTheFirstFibonacciNumberFromValue(int value)
        {
            while (IsFibonacci(value)==false)
            {
                value++;
            }

            return value;
        }
    }
}
