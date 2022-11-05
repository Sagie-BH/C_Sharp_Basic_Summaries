using System;

namespace GoingBackToStatic
{
    /// <summary>
    /// Static modifier makes an item non-instantiable, cannot be instantiated.
    /// The static modifier is used when the data and behavior of a class do not depend on object identity
    /// Static members can be accessed without creating an object of the class
    /// It isn't possible to use this to reference static methods or property accessors.
    /// If the static keyword is applied to a class, all the members of the class must be static.
    /// </summary>
    class Program
    {
        public static class MyStaticClass
        {
            public static int myStaticVariable = 0;

            public static void MyStaticMethod()
            {
                Console.WriteLine("This is a static method.");
            }

            public static int MyStaticProperty { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyStaticClass.myStaticVariable);

            MyStaticClass.MyStaticMethod();

            MyStaticClass.MyStaticProperty = 100;

            Console.WriteLine(MyStaticClass.MyStaticProperty);

            Console.WriteLine("Num of instances before levi = " + Cow.numOfInstances);

            Cow levi = new Cow();
            Console.WriteLine("Num of instances before jon = " + Cow.numOfInstances);
            Cow jon = new Cow();
            Console.WriteLine($"jon Id = {jon.id}\nNum of instances =  {Cow.numOfInstances}");
            Console.ReadLine();
        }

        class Cow
        {
            public static int numOfInstances;
            public int id;
            public Cow()
            {
                id = ++numOfInstances;
            }
        }
    }
}
