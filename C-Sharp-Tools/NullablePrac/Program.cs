using System;

namespace NullablePrac
{
    class Program
    {

        // When ? is used the compiler adds a boolean value to the type


        // Nullable<T>  -  public bool HasValue { get; }

        //Has a value (true) -   doesn't has a value (false)
        static int? GetBalanceFromTaxMan()
        {
            return null;
        }
        static void Main(string[] args)
        {
            int? myReturn = GetBalanceFromTaxMan();

            int? i = 5;
            int? j = null;
            int? sum = i + j;
            //sum = null.... 5 + I don't know = null

            //int? h = 7        translate:
            Nullable<int> h = 7;
        }
    }
}
