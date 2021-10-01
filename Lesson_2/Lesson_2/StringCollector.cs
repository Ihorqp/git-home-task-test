using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class StringCollector
    {
        private readonly List<string> values;

       public StringCollector()
        {
            values= new List<string>();
         }
    public void WriteValues(string @string)
        {
            values.Add(@string);
        }
        public void Print()
        {
            Console.WriteLine("Без цифр:");
         foreach(var val in values)
                Console.WriteLine(val);
        }
    }
}
