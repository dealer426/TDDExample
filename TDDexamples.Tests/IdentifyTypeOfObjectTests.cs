using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDDexamples.Tests
{
    public class IdentifyTypeOfObjectTests
    {
       [Fact]
       public void CustomerForOrders_Over_100_Create_New_LoyalCustomer()
        {
            //Arrange


            //Act
            var customer = CustomerFactory.CreateCustomerInstance(102);

            //Assert
            Assert.IsType<LoyalCustomer>(customer);

        }

        [Fact]
        public void CustomerForOrders_Less_Than_100_Create_New_Customer()
        {
            //Arrange


            //Act
            var customer = CustomerFactory.CreateCustomerInstance(99);

            //Assert
            Assert.IsType<IdentifyTypeOfObject>(customer);

        }

        [Fact]
        public void LoyalCustomerDiscount_Should_Return_10()
        {
            //Arrange
            var customer = CustomerFactory.CreateCustomerInstance(102);

            //Act
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);

            //Assert
            Assert.Equal(10, loyalCustomer.Discount);

        }


    }

   
}
