using System;
using System.Collections.Generic;
using System.Text;

namespace TDDexamples
{
    public class Lists
    {
        public List<string> StuffToBuy = new List<string>();

        public List<int> Fibonacci = new List<int> { 1, 1, 2, 3, 5, 8, 13 };

        public Lists()
        {

        }

        public Lists(string name)
        {

        }

        public void AddStuffToList(string stuff)
        {
            StuffToBuy.Add(stuff);
        }

        public void RemoveStuffFromList(string stuff)
        {
            StuffToBuy.Remove(stuff);
        }


        public List<string> ReturnMyList()
        {
            return StuffToBuy;
        }


    }
}
