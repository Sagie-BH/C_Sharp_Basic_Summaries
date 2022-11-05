using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    //Recursion occurs when a method is called within itself

    class Program
    {
        static void Main(string[] args)
        {
            //Factorial(5) - example
            int factorialAnswer = 0;
            factorialAnswer = Factorial(5);
            Console.WriteLine($"Answer: {factorialAnswer}");

            //Power of 4 - example
            float powerOfAnswer = 0;
            powerOfAnswer = Power(4, 4);

            bool running = true;
            while (running) { };
        }

        //Factorial = 5*4*3*2*1
        private static int Factorial(int factorialNum)
        {
            // Always have an exit condition 
            if (factorialNum == 1)
                return 1;
            return factorialNum * Factorial(factorialNum - 1);

        }
        //Power of - 4 power of 4   =    4 * 4 * 4 * 4
        private static float Power(float num, int powerOf)
        {
            //if power of 1 the return number should be num - 4 power of 1 = 4
            if (powerOf == 1)
                return num;
            return num * Power(num, powerOf - 1);
        }
    }
}
