using System;
using System.Collections.Generic;
using System.Text;

namespace TDDexamples
{
    public class GroceryClass
    {
        public List<string> StuffToBuy = new List<string>();

        public GroceryClass()
        {

        }

        public GroceryClass(string name)
        {

        }

        public void AddStuffToList(string stuff)
        {
            StuffToBuy.Add(stuff);
        }

        public List<string> ReturnMyList()
        {
            return StuffToBuy;
        }


    }
}
