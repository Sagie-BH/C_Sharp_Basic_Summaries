 using System;
using System.Collections.Generic;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(10, 20);

            Calculator.Add(new List<int>() { 1, 2, 3, 4, 5 });
        }
    }
    public class Calculator
    {
        [Obsolete("Use Add(List<int> Numbers) Method")]
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }

        public static int Add(List<int> Numbers)
        {
            int sum = 0;
            foreach (int n in Numbers)
                sum += n;
            return sum;
        }
    }
}
