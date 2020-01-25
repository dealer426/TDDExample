using System;
using System.Collections.Generic;
using System.Text;

namespace TDDexamples
{
    public class GroceryLists
    {
        public List<string> StuffToBuy = new List<string>();

        public GroceryLists()
        {

        }

        public GroceryLists(string name)
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
