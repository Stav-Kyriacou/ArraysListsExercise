using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercide 1
            string[] names = new string[5];

            for (var i = 0; i < names.Length; i++)
            {
                Console.Write("Enter a name: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("------------------------------");

            for (var i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Hello {0}", names[i]);
            }
        }
    }
}
