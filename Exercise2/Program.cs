using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 2
            int[] numbers = {34,5,67,1,99,34,44,78,34,0};
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine("The total is: {0}", total);
        }
    }
}
