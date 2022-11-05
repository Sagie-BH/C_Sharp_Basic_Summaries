using System;
using Sorts;
namespace LibraryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] numbers = new int[5000];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 5001);
            }
            Sort.BubbleSort(numbers);
            Sort.InsertionSort(numbers);
            Sort.SelectionSort(numbers);

            Console.ReadLine();
        }
    }
}
