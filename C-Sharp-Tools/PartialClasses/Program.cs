using System;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer { FirstName = "Alla", LastName = "Akbar" };
            Console.WriteLine(customer.GetFullName());

            //Partial Customer One    
            PartialCustomer partialCustomer = new PartialCustomer { FirstName = "Jesus", LastName = "Christ" };
            //Partial Customer Two   
            Console.WriteLine(partialCustomer.GetFullName());
        }
    }
}
