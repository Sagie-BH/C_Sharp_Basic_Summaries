using System;

namespace GoingBack
{
    /// <summary>
    /// A struct is a value type and a class a reference type.
    /// Structs are stored on the stack, classes are stored on the heap
    /// </summary>
    public struct Customer
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name { get => _name; set => _name = value; }

        public Customer(int Id, string name)
        {
            this._id = Id;
            this._name = name;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Id = {this._id}\nName = {this._name}");
        }
    }
    class Person
    {
        private int _id;
        private string _name;

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Name { get => _name; set => _name = value; }

        public Person(int Id, string name)
        {
            this._id = Id;
            this._name = name;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Id = {this._id}\nName = {this._name}");
        }
    }
    struct Position
    {
        //structs fiells and properties can't have instances
        public int x;
        public int y;

        // Structs methods can't contain explicit parameterless constructors
        // and must be fully assigned
        public Position(int initialX, int initialY)
        {
            x = initialX;
            y = initialY;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person(1, "Adam");  
                                                 //person1.Name = Adam         person1.Id = 1       
            Person person2 = person1;
                                                 // person1.Name = Adam         person1.Id = 1       
                                                 // person2.Name = Adam         person2.Id = 1       

            person2.Name = "Hava";
                                                 // person1.Name = Hava         person1.Id = 1       
                                                 // person2.Name = Hava         person2.Id = 1     
            Console.WriteLine(person1.Name);
                                                 // Output : Hava
            Person person3 = new Person(3, "Oded");
            person3 = person1;
                                                 // person1.Name = Hava         person1.Id = 1       
                                                 // person3.Name = Hava         person3.Id = 1   
            person3.ID = 12;
                                                 // person1.Name = Hava         person1.Id = 12       
                                                 // person3.Name = Hava         person3.Id = 12   
            Console.WriteLine(person1.ID);

            //Exist on the stack
            //c1 &  c2 are value types
            //Changing the id value for c2 won't change c1 id value
            Customer c1 = new Customer(666, "The Devil");
            c1.PrintDetails();
            Customer c2 = c1;
            c2.ID = 2020;
            Console.WriteLine(c1.ID);



            Position pos1 = new Position(4, 5);
            Position pos2 = new Position(45, 55);

            Console.ReadLine();
            
        }
    }
}
