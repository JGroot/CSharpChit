using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsArrayList
{
    class Program
    {
        private static readonly string[] colors = { "MAGENTA", "WHITE", "BLUE", "RED", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(1);
            foreach (var color in colors)
                list.Add(color);

            ArrayList removeList = new ArrayList(removeColors);

            Console.Write("ArrayList: ");
            DisplayInformation(list);

            RemoveColors(list, removeList);

            Console.Write("\n ArrayList after calling RemoveColors(): ");

            DisplayInformation(list);
        }

        private static void DisplayInformation(ArrayList arrayList)
        {
            foreach (var element in arrayList)
                Console.Write(element + " ");
            Console.WriteLine("\n Size = " + arrayList.Count + "; Capacity = " + arrayList.Capacity);

            int index = arrayList.IndexOf("BLUE");

            if (index != -1)
                Console.WriteLine("The arraylist contains Blue at index " + index);
            else
                Console.WriteLine("The arraylist does not contain Blue");
        }

        private static void RemoveColors(ArrayList list, ArrayList removeList)
        {

        }
    }
}
