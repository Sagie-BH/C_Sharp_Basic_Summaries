using System;

namespace ExpressionBodiedMembers
{
    class ExprBodyMethAndProp
    {
        int Id { get; } = 200345;
        string name { get; } = "Chiko";
        string address { get; } = "Tel Aviv";
        double BasicSalary { get; } = 3000;

        /// <summary>  
        /// Expression bodied method  
        /// </summary>  
        public double empHRA() => (BasicSalary * 40) / 100;

        /// <summary>  
        /// Expression bodied property  
        /// </summary>  
        public double empHRAProp => (BasicSalary * 40) / 100;

        /// <summary>  
        /// Expression bodied method  
        /// </summary>  
        public string EmployeeDetail() => $"Id: {Id}\nName: {name}\nAddress: {address}\nHRA: {empHRA()}";

        /// <summary>  
        /// Expression bodied property  
        /// </summary>  
        public string EmployeeProp => $"Id: {Id}\nName: {name}\nAddress: {address}\nHRA: {empHRAProp}";

        /// <summary>
        /// Expression bodied constructor 
        /// </summary>
        public ExprBodyMethAndProp() => BasicSalary = 2500;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

