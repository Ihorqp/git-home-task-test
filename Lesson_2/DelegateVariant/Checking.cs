using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DelegateVariant
{
    class Checkinkg
    {

        public event WriteDelegate writeTooDigit;
        public event WriteDelegate writeTooString;

        public void InptingCheck(string @string)
        {
            var regexString = new Regex(@"\D+");
            var regexDigit = new Regex(@"\d+");


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
