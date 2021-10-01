using System;

namespace DelegateVariant
{
    internal delegate void CheckDelegate(string s);
    internal delegate void WriteDelegate(string s);
    internal delegate void PrintDelegate();
    class Program
    {
        /*
         * У програмі багато коду, можна було б обійтись і без класу Check, але я хотів проілюструвати роботу делегатів
         */

        static void Main(string[] args)
        {
            InputMenu Process               = new InputMenu();                                   
            StringCollector stringCollector = new StringCollector();               
            AlphaNumericCollector alphaNumericCollector = new AlphaNumericCollector();
            Checkinkg check                = new Checkinkg();

            Process.tocheck      += check.InptingCheck;                  //підписуємо метод для перевірки 
            Process.PrintStr     +=stringCollector.Print;                //делегат для виводу стрічок
            Process.PrintNumeric +=alphaNumericCollector.Print;          //делегат для виводу чисел і букв
            check.writeTooDigit  += alphaNumericCollector.WriteValues;   //підписуємо метод для запису у цифри 
            check.writeTooString += stringCollector.WriteValues;         //підписуємо метод для запису у стрінги


            Process.Run();
        }
    }
}
