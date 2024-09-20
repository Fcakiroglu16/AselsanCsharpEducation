using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestExample.MsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(20, 0, 0)]
        public void Divide_ZeroNumber_ThrowException(int a, int b, int result)
        {
            /// AAA Pattern

            //var a = 20;
            //var b = 10;

            //Arrange
            var calculate = new Calculate();


            //Act + Assert

            var Exception = Assert.ThrowsException<Exception>(() => calculate.Divide(a, b));

            Assert.AreEqual("b değeri 0 olamaz", Exception.Message);
        }


        [TestMethod]
        [DataRow(20, 10, 2)]
        public void Calculate_ValidNumbers_ReturnSuccess(int a, int b, int result)
        {
            /// AAA Pattern

            //var a = 20;
            //var b = 10;

            //Arrange
            var calculate = new Calculate();


            //Act
            var resultDivide = calculate.Divide(a, b);


            //Assert
            Assert.AreEqual(result, resultDivide);
        }
    }
}