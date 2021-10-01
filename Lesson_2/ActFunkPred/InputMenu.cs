using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ActFunkPred
{

    class InputMenu
    {
        public Action<string> Input{ get; set; } 
        public Action PrintNum;
        public Action PrintStr;
        public void Run()
        {
            string choice;
            bool exit = false;
            var regexChoice = new Regex("[1-4]");

            #region Меню для ввводу/виводу значень
            do
            {
                Console.Clear();
                Console.Write(@"            Меню 
1 - Ввести значення
2 - Вивести стрiчки без цифр
3 - Вивести стрiчки з цифрами
4 - Завершити
");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Введiть значення:   ");
                         Input(Console.ReadLine());
                        break; 
                    case "2":
                        Console.WriteLine("Лише букви:");
                        PrintStr.Invoke();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("З цифрами:");
                        PrintNum.Invoke();                                        
                        Console.ReadKey();
                        break;
                    case "4":
                        exit = true;
                        choice = "5";
                        break;
                }
            } while (!exit || regexChoice.IsMatch(choice));
            #endregion
        }

     
    }
}
