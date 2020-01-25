using System;
using System.Collections.Generic;
using System.Text;

namespace TDDexamples
{
    public class StringValues
    {

        public string PrefferedName { get; set; }

        public string BuildFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
