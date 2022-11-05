using System;
using System.Diagnostics;

namespace Sorts
{
    public class Sort
    {
        public static void BubbleSort(int[] numbers)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        int swap = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = swap;
                    }
                }
            }
            sw1.Stop();
            Console.WriteLine($"Bubble sort took: {sw1.ElapsedMilliseconds}  miliseconds");
        }
        public static void SelectionSort(int[] numbers)
        {
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int min = 1;
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] < numbers[min])
                    {
                        min = j;
                    }
                }
            }
            sw2.Stop();
            Console.WriteLine($"Selection sort took: {sw2.ElapsedMilliseconds}  miliseconds");
        }
        public static void InsertionSort(int[] numbers)
        {
            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j > 0; j--)
                {
                    int temp = numbers[j - 1];
                    numbers[j - 1] = numbers[j];
                    numbers[j] = temp;
                }
            }
            sw3.Stop();
            Console.WriteLine($"Insertion sort took: {sw3.ElapsedMilliseconds}  miliseconds");

        }
    }
}
