using System;
using System.Collections.Generic;


namespace SubstringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = "abcdefghijklmnopqrstuvwxyzabcdefghijk";
            char[] searchLetters = { 'c', 'a', '$' };

            Console.WriteLine("First 'c' is located at index " + letters.IndexOf('c'));
            Console.WriteLine("First 'a' starting at 1 is located at index " + letters.IndexOf('a', 1));
            Console.WriteLine("First '$' in the 5 position starting at 3 " + letters.IndexOf('$', 3, 5));
            Console.WriteLine("Last 'c' is located at index " + letters.LastIndexOf('c'));
            Console.WriteLine("Last 'a' up to position 25 is located at index " + letters.LastIndexOf('a', 25));
            Console.WriteLine("Last '$' in the 5 position ending at 15 " + letters.LastIndexOf('$', 15, 5));
            Console.WriteLine("First \"def\" is located at index " + letters.IndexOf("def"));
            Console.WriteLine("First \"def\" starting at location 7 is located at index " + letters.IndexOf("def", 7));
            Console.WriteLine("First \"hello\" in the 15 positions starting at location 5 is located at index " + letters.IndexOf("hello", 15, 5));
        }
    }
}
