using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Checking
    {
        //  string @string = null;
        public event WriteУEvent writeTooDigit; //= null;
        public event WriteУEvent writeTooString;// = null;

        public void Check(string @string)
        {
            var regexString = new Regex(@"\D+");
            var regexDigit  = new Regex(@"\d+");


            if (regexDigit.IsMatch(@string))
                writeTooDigit.Invoke(@string); // stringCollector.WriteValues; // записуєму у цифри
            else if (regexString.IsMatch(@string))
                writeTooString.Invoke(@string);
            else
            {
                Console.WriteLine($"{@string} Є недопустиме значення");
                Console.ReadLine();
            }
        }

    }
}
