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
            
            while(input != "stop")                                  //keep asking for a word until "stop" is typed
            {
                Console.Write("Enter a word: ");                    //get user input
                input = Console.ReadLine();

                if(input != "stop")                                 //only add to the list if word is not "stop"
                {
                    words.Add(input);
                }
            }

            Console.WriteLine("-------------------");

            words.Reverse();                                        //reverse order of list

            foreach (string item in words)                          //output every word in the list
            {
                Console.WriteLine(item);                
            }
        }
    }
}
