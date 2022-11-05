using System;

namespace Verbatim
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The man said \n\"Go to hell!\"";
            Console.WriteLine(text);
            Console.ReadLine();

            string withAlertSoung = "\aAlert";
            Console.WriteLine(withAlertSoung);
            Console.ReadLine();

            string verbatimString = @"Say hi: ""Hi"" ";
        }
    }
}
