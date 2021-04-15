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
            int repeatedAmount = 0;

            for (int i = 0; i < 5; i++)                                                             //get user input a specific number of times. Add each input to a list
            {
                Console.Write("Enter a number: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("---------------");
            Console.Write("Enter another number: ");                            
            int input = int.Parse(Console.ReadLine());                                              //Get user input for another number

            for (int i = 0; i < numbers.Count; i++)                                                 //loop through list, check if each is the same as the input. If yes increment counter variable
            {
                if (numbers[i] == input)
                {
                    repeatedAmount++;
                }
            }

            Console.WriteLine("The number {0} was repeated {1} time(s)", input, repeatedAmount);      //write how many times the number was repeated
        }
    }
}
