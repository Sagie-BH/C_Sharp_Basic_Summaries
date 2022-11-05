using System;

namespace NamedParameters
{
    class Person
    {
        string firstName;
        string lastName;
        int age;
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public void AddDetials(string _firstName, string _lastName, int _age)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Age = _age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.AddDetials(_age: 22,
                              _lastName: "Yazpan",
                              _firstName: "Eli");
        }
    }
}
