using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace TDDexamples.Tests
{
    public class GroceryListsTests
    {
        [Fact]
        public void ShouldCreateGroceryObject()
        {
            var grocery = new GroceryLists("Sav-A-Lot");

        }

        [Fact]
        public void ShouldGetOurList_Do_We_Have_a_list()
        {
            // Arrange
            var sut = new GroceryLists();

            // Act
            var myList = sut.ReturnMyList();

            // Assert
            Assert.IsType<List<string>>(myList);
        }

        [Fact]
        public void Can_We_Add_To_The_List()
        {
            var sut = new GroceryLists();

            int initialListCount = sut.ReturnMyList().Count;
            sut.AddStuffToList("stuff");
            var myList = sut.ReturnMyList();

            Assert.Equal(initialListCount + 1, myList.Count);
        }
    }

}
