using System;
using System.Collections.Generic;
using System.Text;

namespace TDDexamples
{
    public class IdentifyTypeOfObject
    {
        public string Name => "Sam";
        public int Age => 52;

        public int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Hello");
            }
            return 100;
        }

    }

    public class LoyalCustomer : IdentifyTypeOfObject
    {
        public int Discount { get; set; }

        public LoyalCustomer()
        {
            Discount = 10;
        }
    }

    public static class CustomerFactory 
    {
        public static IdentifyTypeOfObject CreateCustomerInstance(int orderCount)
        {
            if (orderCount <= 100)
                return new IdentifyTypeOfObject();
            else
                return new LoyalCustomer();
        }
    }

   
}
