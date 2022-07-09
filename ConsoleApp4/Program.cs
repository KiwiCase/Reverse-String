using System;

namespace ReverseString  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string: ");
            string oString = Console.ReadLine();
            char[] stringArray = oString.ToCharArray();
            Array.Reverse(stringArray);
            string rString = new string(stringArray);

            Console.WriteLine($"Your string reversed = {rString}");
        }
    }
}