using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class AlphaNumericCollector
    {
        private readonly List<string> values;
        public AlphaNumericCollector()
        {
            values = new List<string>();
        }

        public void WriteValues(string @string)
        {
            values.Add(@string);
        }
        public void Print()
        {
            Console.WriteLine("З цифрами:");
            foreach (var val in values)
                Console.WriteLine(val);
        }


    }
}
