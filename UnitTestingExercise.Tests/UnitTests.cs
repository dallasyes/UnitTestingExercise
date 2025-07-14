using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(3,4, 5, 12)]
        [InlineData(5,6,7,18)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 3)]//Add test data <-------
        [InlineData(10,5,5)]
        [InlineData(12,5,7)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();
            

            //Act
            var result = calculator.Subtract(minuend, subtrahend);

            //Assert
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(4, 4, 16)]//Add test data <-------
        [InlineData(5,5,25)]
        [InlineData(6,7,42)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(10, 5, 2)]//Add test data <-------
        [InlineData(21,7,3)]
        [InlineData(30,3,10)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, result);

        }

    }
}
