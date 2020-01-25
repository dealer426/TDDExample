using System;
using System.Collections.Generic;
using System.Text;

namespace TDDexamples
{
    public class NumericValues
    {

        public int Age { get; set; } = 5;

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }


        public double AddDouble(double a, double b)
        {
            return a + b;
        }

        public int DecrementAge()
        {
            return --Age;
        }

        public int IncrementAge()
        {
            return ++Age;
        }

        public int Add5ToAge()
        {
            return Age += 5;
        }




    }
}
