using System;
using System.Collections.Generic;
using System.Text;

namespace TDDexamples
{
    public class RangeOfValues
    {
        public string Name => "Sam";
        public int Age => 52;

        public int GetOrdersByName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Hello");
            }
            return 100;
        }

    }
}
