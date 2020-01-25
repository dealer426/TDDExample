using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace TDDexamples.Tests
{
    public class ListsTests
    {
        [Fact]
        public void CreateGroceryObject_Do_We_Have_A_Class_Created()
        {
            var grocery = new Lists("Sav-A-Lot");

        }

        [Fact]
        public void ReturnMyList_Do_We_Have_a_list()
        {
            // Arrange
            var sut = new Lists();

            // Act
            var myList = sut.ReturnMyList();

            // Assert
            Assert.IsType<List<string>>(myList);
        }

        [Fact]
        public void Add_Can_We_Add_An_Item_To_The_List()
        {
            // Arrange
            var sut = new Lists();

            // Act
            int initialListCount = sut.ReturnMyList().Count;
            sut.AddStuffToList("stuff");
            var myList = sut.ReturnMyList();

            // Assert
            Assert.Equal(initialListCount + 1, myList.Count);
        }


        [Fact]
        public void Remove_Can_We_Remove_An_Item_From_The_List()
        {
            // Arrange
            var sut = new Lists();

            // Act
            int initialListCount = sut.ReturnMyList().Count;
            sut.AddStuffToList("stuff");
            sut.RemoveStuffFromList("stuff");
            var myList = sut.ReturnMyList();

            // Assert
            Assert.Equal(initialListCount, myList.Count);
        }
    }

}
