using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClasses
{
    class Customer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
