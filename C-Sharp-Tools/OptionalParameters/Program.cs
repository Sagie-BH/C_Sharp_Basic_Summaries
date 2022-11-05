using System;

namespace OptionalParameters
{
    class Program
    {
        /// <summary>
        /// Optional parameters using an array and params
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="Optional parameters"></param>
        public static void AddNumbers(int firstNumber, int secondNumber, params int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int n in restOfNumbers)
                {
                    result += n;
                }
            }
            Console.WriteLine($"Sum is:  {result}");
        }
        /// <summary>
        /// Optional parametes using method overloading
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            Console.WriteLine($"Sum is:  {result}");

        }
        /// <summary>
        /// Optional parameter using a default value
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        public static void AddMore(int first, int second, int third = 5)
        {
            int result = first + second + third ;

        }
        static void Main(string[] args)
    {
            AddNumbers(4, 10);

            AddNumbers(20, 10, 4, 44, 100);

            AddMore(1, 1);

            AddMore(2, 4, 6);


    }


    }
}


