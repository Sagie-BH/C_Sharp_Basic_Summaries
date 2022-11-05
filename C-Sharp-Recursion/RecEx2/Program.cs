using System;

namespace RecEx2
{
    class Program
    {
        static int count = 1;
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("How many numbers to print?");
            while(!int.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Only numbers!");
            Console.WriteLine(CountUp(number));
            Console.ReadLine();

        }
        private static int CountUp(int n)
        {
            if (n == 1)
                return 1;
            if (n >= count)
            {
                Console.WriteLine(count);
                count++;
            }
            return CountUp(n);
        }
    }
}
