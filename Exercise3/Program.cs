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

            for (int i = 0; i < 5; i++)                                                     //ask for a number a specific amount of times, add each to a list
            {
                Console.Write("Enter a number: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("---------------");                                           
            Console.Write("Enter another number: ");                                        //ask for another number
            int input = int.Parse(Console.ReadLine());

            if (numbers.Contains(input))
            {
                Console.WriteLine("{0} was already entered", input);                        //if the new number is in the list
            }
            else
            {
                Console.WriteLine("{0} was NOT previously entered", input);                 //if the new number is not in the list
            }
        }
    }
}
