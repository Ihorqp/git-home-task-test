using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActFunkPred
{
    class StringCollector
    {
        private readonly List<string> values;
        public Action<List<string>> View { get; set; }
        public StringCollector()
        {
            values = new List<string>();
        }

        public void Write(string val)
        {
            values.Add(val);
        }
        public void Showe()
        {
            foreach (var val in values)
                Console.WriteLine(val);
        }
    }
}
