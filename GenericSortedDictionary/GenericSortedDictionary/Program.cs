using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GenericSortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dictionary = CollectWords();
            DisplayDictionary(dictionary);
        }

        private static SortedDictionary<string, int> CollectWords()
        {
            SortedDictionary<string, int> dictionary = new SortedDictionary<string,int>();

            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string[] words = Regex.Split(input, @"\s+");

            foreach(var word in words)
            {
                string wordKey = word.ToLower();
                if (dictionary.ContainsKey(wordKey))
                    ++dictionary[wordKey];
                else               
                    dictionary.Add(wordKey, 1);                       
            }
            return dictionary;
        }

        private static void DisplayDictionary<K,V>(SortedDictionary<K,V> dictionary)
        {
            Console.WriteLine("\nSorted dictionary contains: \n{0,-12}{1,-12}",
                            "Key: ", "Value:");

            foreach (K key in dictionary.Keys)
                Console.WriteLine("{0,-12}{1, -12}", key, dictionary[key]);

            Console.WriteLine("\nSize: {0}", dictionary.Count);
        }
    }
}
