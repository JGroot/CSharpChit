using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        private static double[] doubleElements = new double[] {1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
        private static int[] intElements = new int[] {1, 2, 3, 4, 5, 6, 7, 8 , 9, 10, 11};

        private static Stack<double> doubleStack;
        private static Stack<int> intStack;

        static void Main(string[] args)
        {
            doubleStack = new Stack<double>(5);
            intStack = new Stack<int>(10);

            TestPushDouble();
            TestPopDoubel();
            TestPushInt();
            TestPopInt();
        }
    }
}
