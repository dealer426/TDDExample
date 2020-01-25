using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDDexamples.Tests
{
    public class StringValuesTests
    {

        [Fact]
        public void BuildFullName_Takes_two_String_And_Returns_Full_Name()
        {
            //Arrange
            var name = new StringValues();

            //Act
            var fullName = name.BuildFullName("We Can", "Code IT");

            //Assert
            Assert.Equal("We Can Code IT", fullName);
        }

        [Fact]
        public void BuildFullName_Takes_two_String_And_Contains_Part_of_Name()
        {
            //Arrange
            var name = new StringValues();

            //Act
            var fullName = name.BuildFullName("We Can", "Code IT");

            //Assert
            Assert.Contains("We Can", fullName);
        }

        [Fact]
        public void BuildFullName_Takes_two_String_Ignores_Case()
        {
            //Arrange
            var name = new StringValues();

            //Act
            var fullName = name.BuildFullName("We Can", "Code IT");

            //Assert
            Assert.Equal("we can code it", fullName, ignoreCase: true);
        }

        [Fact]
        public void BuildFullName_Takes_two_String_Ignores_Case_Part_Of_String()
        {
            //Arrange
            var name = new StringValues();

            //Act
            var fullName = name.BuildFullName("We Can", "Code IT");

            //Assert
            Assert.Contains("we can", fullName, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void BuildFullName_Takes_two_String_Ends_With()
        {
            //Arrange
            var name = new StringValues();

            //Act
            var fullName = name.BuildFullName("We Can", "Code IT");

            //Assert
            Assert.EndsWith("Code IT", fullName);
        }

        [Fact]
        public void BuildFullName_Validate_Dat_With_Regular_Expression()
        {
            //Arrange
            var name = new StringValues();

            //Act
            var fullName = name.BuildFullName("Sam", "Burns");

            //Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", fullName);
        }


        [Fact]
        public void PrefferedName_MustBeNull()
        {  
            //Arrange
            var name = new StringValues();

            //Act
            //Just call the property directly in Assert, no need for a new variable

            //Assert
            Assert.Null(name.PrefferedName);
        }

        [Fact]
        public void PrefferedName_Can_I_Assign_a_Name()
        {
            //Arrange
            var name = new StringValues();

            //Act
            name.PrefferedName = "Sam";

            //Assert
            Assert.NotNull(name.PrefferedName);
        }

        [Fact]
        public void PrefferedName_Always_Return_A_Value()
        {
            //Arrange
            var name = new StringValues();

            //Act
            var fullName = name.BuildFullName("Sam", "Burns");

            //Assert
            Assert.True(!string.IsNullOrEmpty(fullName));
        }

    }
}
