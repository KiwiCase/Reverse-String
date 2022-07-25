using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter your string: ");
            string inputString = Console.ReadLine();
            string stringReverse = string.Empty;
            bool b = inputString.Equals(stringReverse, StringComparison.OrdinalIgnoreCase);

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                stringReverse += inputString[i];
            }

            if (b == false)
            {
                Console.WriteLine($"{inputString} is a Palindrome!");
            }

            else
            {
                Console.WriteLine(stringReverse);
            }



        }
    }
}
