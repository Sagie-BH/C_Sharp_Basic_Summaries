using System;

namespace GenericConstraints
{
    class ClassOne { public ClassOne() { } }
    class ClassOneAndAHalf : ClassOne { public ClassOneAndAHalf(string name, int age) { } }
    class ClassTwo : ClassOne { public ClassTwo() { } }
    class ClassThree { public ClassThree() { } }
    class Program
    {
        static T ProduceA<T>() where T : ClassOne, new()
        {
            T returnVal = new T();
            return returnVal;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
