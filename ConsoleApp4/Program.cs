using System;

namespace ReverseString  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string: ");
            string ogString = Console.ReadLine();
            char[] stringArray = ogString.ToCharArray();
            Array.Reverse(stringArray);
            string revString = new string(stringArray);
            bool b = ogString.Equals(revString, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + ogString + " is a Palindrome!");
            } else
            {
                Console.WriteLine($"Your string reversed = {revString}");
            }

            
        }
    }
}