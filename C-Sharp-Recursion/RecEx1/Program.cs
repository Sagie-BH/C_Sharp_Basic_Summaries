using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int answer = 0;
            Console.WriteLine("How manu numbers to print?");
            while (!int.TryParse(Console.ReadLine(), out count))
                Console.WriteLine("Choose only numbers");
            answer = (Counting(count));
            Console.WriteLine(answer);
            Console.ReadLine();
        }
        private static int Counting(int num)
        {
            if (num == 1)
                return 1;
            Console.WriteLine(num);
            return Counting(num - 1);
        }
    }
}
