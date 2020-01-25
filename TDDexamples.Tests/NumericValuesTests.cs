using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDDexamples.Tests
{
    public class NumericValuesTests
    {

        [Fact]
        public void Add_GivenTwoIntValues_Returns_Int()
        {
            //Arrange
            var myNumbers = new NumericValues();

            //Act
            var result = myNumbers.Add(1, 2);

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_Returns_Double()
        {
            //Arrange
            var myNumbers = new NumericValues();

            //Act
            var result = myNumbers.AddDouble(1.2, 4.5);

            //Assert
            Assert.Equal(5.7, result);
        }

        [Fact]
        public void Multiply_GivenTwoIntValues_Returns_Int()
        {
            //Arrange
            var myNumbers = new NumericValues();

            //Act
            var result = myNumbers.Multiply(2, 3);

            //Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Subtract_GivenTwoIntValues_Returns_Int()
        {
            //Arrange
            var myNumbers = new NumericValues();

            //Act
            var result = myNumbers.Subtract(6, 4);

            //Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Decrement_Age_Property_Returns_One_Less_From_original_Value()
        {
            //Arrange
            var myNumbers = new NumericValues();

            //Act
            var startingAge = myNumbers.Age;
            var decramentAge = myNumbers.DecrementAge();

            //Assert
            Assert.Equal(startingAge -1, decramentAge);
        }

        [Fact]
        public void Increment_Age_Property_Returns_One_More_From_original_Value()
        {
            //Arrange
            var myNumbers = new NumericValues();

            //Act
            var startingAge = myNumbers.Age;
            var incrementAge = myNumbers.IncrementAge();

            //Assert
            Assert.Equal(startingAge + 1, incrementAge);
        }


        [Fact]
        public void Add5_Age_Property_Returns_5_More_From_original_Value()
        {
            //Arrange
            var myNumbers = new NumericValues();

            //Act
            var startingAge = myNumbers.Age;
            var incrementAge = myNumbers.Add5ToAge();

            //Assert
            Assert.Equal(startingAge + 5, incrementAge);
        }



    }
}
