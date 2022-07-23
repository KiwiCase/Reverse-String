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

            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                stringReverse += inputString[i];
            }

            Console.WriteLine(stringReverse);

        }
    }
}
