using System;
using System.Timers;

namespace Lesson_2
{
    /* public delegate void MyDelegate();
     public delegate string MyDel(string s1, string s2);


     public delegate void JokeReady(string joke);
     public class JokeGenerator
     {
         public JokeGenerator()
         {
             Timer timer = new Timer(500);
             timer.Start();
             timer.Elapsed += Timer_Elapsed;
         }

         private void Timer_Elapsed(object sender, ElapsedEventArgs e)
         {

         }
         public JokeGenerator(string joke)
         {

         }
         private int index = -1;

         private string[] jokes = new string[]
         {
             @"Hello World"
         };
     }

     public class GenClass<T>
     {
         static void Print()
         {
             Console.WriteLine("Hello");
         }
     }

 */


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







            //string s = null;
            //MyDelegate myDelegateInstance = delegate { Console.WriteLine("Hello"); };
            //MyDel myDel = delegate (string s1, string s2) { return s1 + s2; };
            //myDelegateInstance();
            //s = myDel("Hello", " World");
            //Console.WriteLine(s);

            //Console.ReadKey();


            //   var j1 = new JokeGenerator();
            //  j1 = new object();





        }
    }
}
