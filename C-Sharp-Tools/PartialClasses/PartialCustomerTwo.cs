using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClasses
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
