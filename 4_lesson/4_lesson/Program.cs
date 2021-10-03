using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
/*Нижче є завдання, які слід вирішити використовуючи лише Linq. 
* Для початку застосуйте функцію String.Split, також вам можуть пригодитися наступні функції:
* String.Join, Enumerable.Range, Zip, Aggregate, SelectMany і клас TimeSpan.
На вхід є стрічка  "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert" 
Кожному гравцеві надайте номер, починаючи з 1, щоб вийшла стрічка подібна : "1. Davis, 2. Clyne, 3. Fonte" ...

Візьміть стрічку "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988"
і перетворіть її на IEnumerable гравців в порядку віку (і ще бажано вивести вік)

Візьміть стрічку "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27", яка відображає довжину пісень в хвилинах і секунда і обрахуйте загальну довжину всіх пісень.*/
namespace _4_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert";
            string[] str2 = @string.Split(',');
            var diapazon = Enumerable.Range(1, str2.Length);

            var result = diapazon.Zip(str2, (m, n) => m + ". " + n.Trim(' '));

            foreach (var val in result)
                Console.WriteLine(val);



            var str3 = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988";
            string[] str4 = str3.Split(';');

            var sortedMonths = str4
              .Select(x => new
              {
                  name = x.Split(',')[0],
                  age = ((DateTime.Now.Year - (DateTime.Parse(x.Split(',')[1])).Year))
              })
              .OrderByDescending(x => x.age);

            foreach (var val in sortedMonths)
                Console.WriteLine(val.name + " " + (val.age));


            string songs = "4:1,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";
            string[] songsArr = songs.Split(',');

            var S1 = songsArr
             .Select(x => new
             {
                 lenth = TimeSpan.Parse(x)
             })
             .Sum(x => x.lenth.TotalMinutes);

            Console.WriteLine($"Довжина всіх пісень {S1} хвилин i {S1 % 60} секунд");
        }
    }
}
