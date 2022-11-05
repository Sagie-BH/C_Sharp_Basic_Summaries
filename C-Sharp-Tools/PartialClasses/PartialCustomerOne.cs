﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClasses
{
    public partial class PartialCustomer
    {
        private string _firstName;
        private string _lastName;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
    }
}
