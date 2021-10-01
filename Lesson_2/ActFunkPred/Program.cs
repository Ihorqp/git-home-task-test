using System;
using System.Text.RegularExpressions;

namespace ActFunkPred
{
    class Program
    {
        static void Main(string[] args)
        {
            InputMenu Process = new InputMenu();
            Checkinkg checkHandler = new Checkinkg();

            StringCollector stringCollector = new StringCollector();
            AlphaNumericCollector alphaNumericCollector = new AlphaNumericCollector();

            Process.Input+= checkHandler.InputCheck;
            Process.PrintNum += alphaNumericCollector.Showe;
            Process.PrintStr += stringCollector.Showe;

            checkHandler.WriteNum += alphaNumericCollector.Write;
            checkHandler.WriteStr += stringCollector.Write;

            Process.Run();
        }
    }
}

