using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDDexamples.Tests
{
    public class RangeOfValuesTests
    {
        [Fact]
        public void Name_Name_Is_Not_Empty()
        {
            //Arange
            var person = new RangeOfValues();

            //Act

            //Assert

            //Check to make sure its not Null
            Assert.NotNull(person.Name);

            //Check to make sure the string i snot empty
            Assert.False(string.IsNullOrEmpty(person.Name));
        }

        [Fact]
        public void Age_Does_It_Fall_Within_A_Range()
        {
            //Arrange
            var person = new RangeOfValues();

            //Act

            //Assert
            Assert.InRange(person.Age, 25, 60);
        }

        [Fact]
        public void GetOrdersByName_Not_Null()
        {
            //Arrange
            var person = new RangeOfValues();

            //Act

            //Assert
            //Looks at the otuput of the if statement in the method
            Assert.Throws<ArgumentException>(()=> person.GetOrdersByName(null));

        }

        [Fact]
        public void GetOrdersByName_Capture_Return_Message_When_Error_Is_Thrown()
        {
            //Arrange
            var person = new RangeOfValues();

            //Act

            //Assert
            //Looks at the otuput of the if statement in the method
            //sets the exception to the var below
            var exceptionDetails= Assert.Throws<ArgumentException>(() => person.GetOrdersByName(null));

            //Does the exception Message return hello
            Assert.Equal("Hello", exceptionDetails.Message);

        }

    }
}
