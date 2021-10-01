using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateVariant
{
    class StringCollector
    {
        private readonly List<string> values;

        public StringCollector()
        {
            values = new List<string>();
        }

        public void WriteValues(string val)
        {
            values.Add(val);
        }

        public void Print()
        {
            Console.WriteLine("Без цифр:");
            foreach (var val in values)
                Console.WriteLine(val);
        }
    }
}
