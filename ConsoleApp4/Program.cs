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

            Console.WriteLine($"Your string reversed = {revString}");
        }
    }
}