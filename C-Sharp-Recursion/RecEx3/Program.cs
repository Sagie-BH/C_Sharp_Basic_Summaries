using System;

namespace RecEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Choose a number:");
            while (!int.TryParse(Console.ReadLine(), out num))
                Console.WriteLine("Only numbers");
            int answer = SumOfNaturalNumbersOf(num);
            Console.WriteLine(answer);
            Console.Read();
        }
        private static int SumOfNaturalNumbersOf(int num)
        {
            if (num == 1)
                return 1;
            return num + SumOfNaturalNumbersOf(num - 1);
        }
    }
}
