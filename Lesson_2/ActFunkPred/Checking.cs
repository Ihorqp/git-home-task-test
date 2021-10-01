using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ActFunkPred
{
    class Checkinkg
    {
        Regex patternStr = new Regex(@"\D+");
        Regex patternNum = new Regex(@"\d+");

        public Action<string> WriteStr;
        public Action<string> WriteNum;


        public void InputCheck(string @string)
        {
            if (patternNum.IsMatch(@string))
                WriteNum(@string);
           else if (patternStr.IsMatch(@string))
                WriteStr(@string);
            else 
            {
                Console.WriteLine($"{@string} Є недопустиме значення");
                Console.ReadLine();
            }
        }

     
    }

}

