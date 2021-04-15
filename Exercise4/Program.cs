using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 4
            List<int> numbers = new List<int>();
            int repeatAmount = 0;
            int numLoops = 5;

            for (int i = 0; i < numLoops; i++)
            {
                Console.Write("Enter a number: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("---------------");
            Console.Write("Enter another number: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == input)
                {
                    repeatAmount++;
                }
            }

            Console.WriteLine("The number {0} was repeated {1} time(s)", input, repeatAmount);
        }
    }
}
