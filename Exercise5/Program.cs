using System;
using System.Collections.Generic;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 5
            List<string> words = new List<string>();
            string input = "";
            
            while(input != "stop")
            {
                Console.Write("Enter a word: ");
                input = Console.ReadLine();

                if(input != "stop")
                {
                    words.Add(input);
                }
            }

            Console.WriteLine("-------------------");

            words.Reverse();

            foreach (string item in words)
            {
                Console.WriteLine(item);                
            }
        }
    }
}
