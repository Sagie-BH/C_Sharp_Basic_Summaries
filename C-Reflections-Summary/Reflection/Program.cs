using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);

            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine($"Type: {type.Name}\t BaseType: {type.BaseType}");

                var props = type.GetProperties();
                foreach (var prop in props)
                {
                    Console.WriteLine($"\tProperty: {prop.Name}\tPropertyType: {prop.PropertyType}");
                }

                var fields = type.GetFields();
                foreach (var field in fields)
                    Console.WriteLine($"\tField: {field.Name}");

                var methods = type.GetMethods();
                foreach (var method in methods)
                    Console.WriteLine($"\tMethod: {method.Name}");
            }

            var sample = new Sample { Name = "Sagie", age = 32 };

            // Runtime Operation
            var sampleType = sample.GetType();

            // Compiletime operation    
            // var sampleTypeOf = typeof(Sample);

            var nameProperty = sampleType.GetProperty("Name");
            Console.WriteLine($"Property: {nameProperty.GetValue(sample)}");

            // Execution without directly calling it
            var myMethod = sampleType.GetMethod("Method");
            myMethod.Invoke(sample, null);
        }

    }
    public class Sample
    {
        public int age;
        public string Name { get; set; }

        public void Method() { Console.WriteLine("Jahri"); }
    }
}
