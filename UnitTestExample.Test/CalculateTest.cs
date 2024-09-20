namespace UnitTestExample.Test
{
    public class CalculateTest
    {
        [Theory]
        [InlineData(20, 10, 2)]
        [InlineData(30, 10, 3)]
        [InlineData(40, 20, 2)]
        public void Divide_Valid_ReturnsSuccess(int a, int b, int result)
        {
            /// AAA Pattern

            //var a = 20;
            //var b = 10;

            //Arrange
            var calculate = new Calculate();


            //Act
            var resultDivide = calculate.Divide(a, b);


            //Assert
            Assert.Equal(result, resultDivide);
        }
    }
}