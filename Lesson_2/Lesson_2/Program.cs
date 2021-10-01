using System;
using System.Timers;

namespace Lesson_2
{
 
    public delegate void CheckIvent(string s);
    public delegate void WriteУEvent(string s);
    public delegate void PrintDelegateStr();
    public delegate void PrintDelegateDigit();


    class Program
        {
        public static string Raz(System.String V, string rez)
        {
            return V + rez;
        }
        /*Зробити 3-ма варіантами: Event, Delegate, Action/Func/Predicate delegate наступне завдання.
         * Консольна програма має дозволяти користувачеві вводити безмежну кількість стрічок. 
         * Стрічку в якій є хоча б одна цифра повинен опрацьовувати клас з назвою AlphaNumericCollector,
         * в іншому випадку клас StringCollector.
         * Взаємодію між вводом даних і згаданими класами слід реалізувати через події/делегати
         * Зони відповідальності класів старайтеся зробити максимально подібно, як в JokeGenerator*/
        static void Main(string[] args)
            {
            InputMenu Process = new InputMenu();
            StringCollector stringCollector = new StringCollector();
            AlphaNumericCollector alphaNumericCollector = new AlphaNumericCollector();
            Checking check = new Checking();

            Process.tocheck += check.Check;//  stringCollector.WriteValues;      //підписуємо метод для перевірки 
            Process.PrintStr=      new PrintDelegateStr(stringCollector.Print);   //делегат для виводу стрічок
            Process.PrintNumeric = new PrintDelegateDigit(alphaNumericCollector.Print);   //делегат для виводу чисел і букв
            check.writeTooDigit += alphaNumericCollector.WriteValues;             //підписуємо метод для запису у цифри 
            check.writeTooString += stringCollector.WriteValues;                  //підписуємо метод для запису у стрінги

            
            Process.Run();


        }
    }
}
