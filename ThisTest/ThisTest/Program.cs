using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleTime what = new SimpleTime(23, 43, 45);

            Console.WriteLine(what.BuildString());
        }

        public class SimpleTime
        {
            private int hour;
            private int minute;
            private int second;

            public SimpleTime(int hour, int minute, int second)
            {
                this.hour = hour;
                this.minute = minute;
                this.hour = hour;
            }

            public string BuildString()
            {
                return string.Format("{0,24}:{1}\n:{2,24}: {3}",
                    "this.ToUniversalString()", this.ToUniversalString(),
                    "ToUniversalString()", ToUniversalString());
            }

            public string ToUniversalString()
            {
                return string.Format("{0:24}:{1:D2}:{2:D2}",this.hour, this.minute, this.second);
            }

            //public override string ToString()
            //{
            //    return string.Format("{0}:{1:D2}:{2:D2} {3}",
            //        this.hour, this.minute, this.second);
            //}
        }
    }
}
