using System;
using System.Collections;
using System.Collections.Generic;


namespace CSList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();

            items.Add("red");
            items.Add("blue");
            items.Add("green");
            items.Insert(0, "purple");

            foreach (string item in items)
                Console.WriteLine(item);
        }
    }
}
