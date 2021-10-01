using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActFunkPred
{
    class AlphaNumericCollector
    {

        private readonly List<string> values;
       
        public AlphaNumericCollector()
        {
            values = new List<string>();
        }
      
        public void Write(string val)
        {
            values.Add(val);
        }

          public  void Showe()
        {
            foreach (var val in values)
                Console.WriteLine(val);
        }
        
    }
}
