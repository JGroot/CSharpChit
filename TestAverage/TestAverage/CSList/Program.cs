using System;
using System.Collections;
using System.Collections.Generic;


namespace CSList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>() { "yellow"};

            items.Add("red");
            items.Add("blue");
            items.Add("green");
            items.Insert(0, "purple");

            DisplayArray(items);
           
            Console.WriteLine("Removing yellow....");
            items.RemoveAt(1);
            DisplayArray(items);
           
        }

        private static void DisplayArray(List<string> items)
        {
            foreach (string item in items)
                Console.WriteLine(items.IndexOf(item) + "  " + item);
        }
    }
}
