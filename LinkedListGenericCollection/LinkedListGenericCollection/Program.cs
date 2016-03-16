using System;
using System.Collections.Generic;


namespace LinkedListGenericCollection
{
    class Program
    {
        private static readonly string[] colors = { "black", "yellow", "green", "blue", "violet", "silver" };
        private static readonly string[] colors2 = { "gold", "white", "brown", "blue", "gray" };

        static void Main(string[] args)
        {
            LinkedList<string> list1 = new LinkedList<string>();
            foreach (var color in colors)
                list1.AddLast(color);

            LinkedList<string> list2 = new LinkedList<string>(colors2);

            Concatenate(list1, list2);
            PrintList(list1);

            Console.WriteLine("\nConverting strings in list1 to uppercase \n");
            ToUppercaseStrings(list1);
            PrintList(list1);

            Console.WriteLine("\nDeleting strings between BLACK and BROWN\n");
            RemoveItemsBetween(list1, "BLACK", "BROWN");

            PrintList(list1);
            PrintReversedList(list1);

        }

        private static void PrintList<T>(LinkedList<T> list)
        {
            Console.WriteLine("Linked List: ");

            foreach (T value in list)
                Console.WriteLine("{0} ", value);
            Console.WriteLine();
        }

        private static void Concatenate<T>(LinkedList<T> list1, LinkedList<T> list2)
        {
            foreach (T value in list2)
                list1.AddLast(value);
        }

        private static void ToUppercaseStrings(LinkedList<string> list)
        {
            LinkedListNode<string> currentNode = list.First;

            while (currentNode != null)
            {
                string color = currentNode.Value;
                currentNode.Value = color.ToUpper();
                currentNode = currentNode.Next;
            }
        }

        private static void RemoveItemsBetween<T>(LinkedList<T> list, T startItem, T endItem)
        {
            LinkedListNode<T> currentNode = list.Find(startItem);
            LinkedListNode<T> endNode = list.Find(endItem);

            while(currentNode.Next != null && currentNode.Next != endNode)
            {
                list.Remove(currentNode.Next);
            }

        }

        private static void PrintReversedList<T>(LinkedList<T> list)
        {
            Console.WriteLine("Reversed List: ");
            LinkedListNode<T> currentNode = list.Last;
            while (currentNode != null)
            {
                Console.Write("{0} ", currentNode.Value);
                currentNode = currentNode.Previous;
            }

            Console.WriteLine();
        }
    }
}
