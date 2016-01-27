using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrModConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Happy ";
            string str2 = "Birthday";

            Console.WriteLine(str1 + str2);
            Console.WriteLine(string.Concat(str1, str2));

            string str3 = "Cheers";
            string str4 = "GOOD BYE";
            string str5 = "     spaces      ";

            Console.WriteLine(str3.Replace('e', 'E'));
            Console.WriteLine(str3.ToUpper());
            Console.WriteLine(str5.Trim());
            Console.WriteLine(str4.ToLower());

        }
    }
}
