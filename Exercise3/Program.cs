using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 3
            List<int> numbers = new List<int>();
            int numLoops = 5;

            for (int i = 0; i < numLoops; i++)
            {
                Console.Write("Enter a number: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("---------------");
            Console.Write("Enter another number: ");
            int input = int.Parse(Console.ReadLine());

            if (numbers.Contains(input))
            {
                Console.WriteLine("{0} was already entered", input);   
            }
            else
            {
                Console.WriteLine("{0} was NOT previously entered", input);
            }
        }
    }
}
