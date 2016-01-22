using System;
using System.Collections;
using System.Collections.Generic;


namespace RectAndJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] rectangular = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[][] jagged = 
            {
               new int[] {1,2},
               new int[] {3},
               new int[] {4,5,6}
            };

            OutputArray(rectangular);
            Console.WriteLine();
            OutputArray(jagged);

            Console.WriteLine("Element: ", jagged[0][0].ToString());
        }

        private static void OutputArray(int[,] array)
        {
            Console.WriteLine("Values in the rectangular array by row are");
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                    Console.WriteLine(" {0}", array[row, column]);

                Console.WriteLine();
            }
        }

        private static void OutputArray(int[][] array)
        {
            Console.WriteLine("Values in the jagged array by row are");
            foreach (int[] row in array)
            {
                foreach (int[] column in array)
                    Console.WriteLine("{0} ", column.ToString());

                Console.WriteLine();
            }
        }
    }
}
