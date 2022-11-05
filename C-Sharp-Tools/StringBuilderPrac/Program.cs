using System;
using System.Text;

namespace StringBuilderPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //sting is immutable - when it's created it can't be changed
            // 5 refrences exists in the heap and only 1 is available
            string userstring = "A";
            userstring += " B";
            userstring += " C";
            userstring += " D";
            userstring += " E";
            // the only value available is "A B C D E"

            //StringBuilder is mutale - it can be changed
            //StringBuilder points to the same value
            StringBuilder newstring = new StringBuilder();
            
            newstring.Append('-', 6);
            newstring.Append(" Hi Everyone :)");
            newstring.Append('-', 6);
            //newstring is a refrence, it's created once on the heap

            newstring.AppendLine();
            newstring.Append("How are you?");

            newstring.Replace("How are you?", "Replaced");

            newstring.Remove(0, 7);
            newstring.Insert(0, "Hello again");

            StringBuilder anotherString = new StringBuilder("Hi");
            anotherString.AppendLine("How are you?").AppendLine("string builder").Insert(5, 10);
        }
    }
}
