using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(0,0,0,0)]
        [InlineData(1,1,1,3)]
        [InlineData(-1, -2, -6, -9)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods x = new UnitTestMethods();

            //Act
            int actual = x.AddNum(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,2,2)]
        [InlineData(10, -2, 12)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods x = new UnitTestMethods();
            //Act

            int actual = x.SubNum(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,4)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods x = new UnitTestMethods();
            //Act
            int actual = x.MultNum(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,1)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods x = new UnitTestMethods();
            //Act
            int actual = x.DivNum(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
