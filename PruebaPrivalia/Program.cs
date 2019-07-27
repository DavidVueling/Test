using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPrivalia
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo option;
            string line;
            int value;
            do
            {
                Console.Clear();
                Console.WriteLine("Fibonacci operations");
                Console.WriteLine("--------------------");
                Console.WriteLine(
                                        "1) Fibonacci(n)" + "\n" + 
                                        "2) Is it a Fibonacci number?" + "\n" +
                                        "3) Find index of Fibonacci number" +"\n" + 
                                        "4) Find a number by lenght" + "\n" + 
                                        "5) Get the first fibonacci number from value" + "\n" +
                                        "6) Exit" + "\n" );

                Console.Write("Chose an option: ");
                option = Console.ReadKey(true);
                switch (option.Key)
                {
                    case ConsoleKey.D1  :
                        Console.Clear();
                        Console.WriteLine("Fibonacci(n)..");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Give me a number motherfucker");
                        Int32.TryParse(Console.ReadLine(),out value);
                        WriteFibonacciSequenceByNumber(value);
                        Console.WriteLine("Press a key to continue");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Is it a Fibonacci number?");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Give me a number motherfucker");
                        Int32.TryParse(Console.ReadLine(), out value);
                        WriteIfItsFibonacciNumber(value);
                        Console.WriteLine("Press a key to continue");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Find index of Fibonacci number..");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Give me a number motherfucker");
                        Int32.TryParse(Console.ReadLine(), out value);
                        WriteIndexOfFibonacciNumber(value);
                        Console.WriteLine("Press a key to continue");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Find me a number by lenght");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Give me a number of digits");
                        Int32.TryParse(Console.ReadLine(), out value);
                        WriteANumberByLength(value);
                        Console.WriteLine("Press a key to continue");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D5:
                        Console.Clear();
                        Console.WriteLine("Get the first fibonacci number from value");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Give me a value to start");
                        Int32.TryParse(Console.ReadLine(), out value);
                        WriteTheFirstFibonacciFromValue(value);
                        Console.WriteLine("Press a key to continue");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Exit...");
                        
                        break;
                }
                
            } while (option.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }

        public static void WriteFibonacciSequenceByNumber(int value)
        {
            for (int i = 1; i <= value; i++)
                Console.WriteLine(Fibonacci.IsFibonacci(i) ? i +
                                                             " is a Fibonacci Number and index is " + Fibonacci.FindIndexOfFibonacciNumber(i)
                    : i + " is a not Fibonacci Number");
        }

        public static void WriteIndexOfFibonacciNumber(int value)
        {
            if (Fibonacci.IsFibonacci(value))
            {
                Console.WriteLine("The index of " + value + " is: " + Fibonacci.FindIndexOfFibonacciNumber(value));
            }
            
        }

        public static void WriteIfItsFibonacciNumber(int value)
        {
            Console.WriteLine(Fibonacci.IsFibonacci(value) ? value + " is a Fibonacci Number" : value + " is a not Fibonacci Number");

        }

        public static void WriteANumberByLength(int lenght)
        {
            Console.WriteLine(Fibonacci.FindANumberByLenght(lenght));

        }

        public static void WriteTheFirstFibonacciFromValue(int value)
        {
            Console.WriteLine(Fibonacci.GetTheFirstFibonacciNumberFromValue(value));

        }

    }
}
