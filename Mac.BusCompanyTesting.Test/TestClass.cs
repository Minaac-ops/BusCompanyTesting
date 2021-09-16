using System.Security.Cryptography;
using TestToolsToXunitProxy;
using Xunit;
using Assert = TestToolsToXunitProxy.Assert;

namespace Mac.BusCompanyTesting.Test
{
    [TestClass]
    public class TestClass
    {
        [Theory]
        [InlineData(6, 50, 290)]
        [InlineData(0, 0, 130)]
        [InlineData(2, 0, 130)]
        public void TestBelow100Km(int pass, int km, double expected)
        {
            //Arrange
            IPriceCalculator c = new PriceCalculator();
            //Act
            double actualRes = c.TotalCost(pass, km);
            //Assert
            Assert.AreEqual(expected,actualRes);
        }

        [Theory]
        [InlineData(10, 200, 725)]
        [InlineData(5, 200, 725)]
        public void TestPassUnder12KmOver100Under500(int pass, int km, double expected)
        {
            //Arrange
            IPriceCalculator c = new PriceCalculator();
            //Act
            double actualRes = c.TotalCost(pass, km);
            //Assert
            Assert.AreEqual(expected, actualRes);
        }

        [Theory]
        [InlineData(20, 300, 1050)]
        [InlineData(15, 300, 1050)]
        public void TestPassOver12KmOver100Under500(int pass, int km, double expected)
        {
            //Arrange
            IPriceCalculator c = new PriceCalculator();
            //Act
            double actualRes = c.TotalCost(pass, km);
            //Assert
            Assert.AreEqual(expected, actualRes);
        }

        [Theory]
        [InlineData(30, 700, 1705)]
        [InlineData(10, 700, 1705)]
        public void TestKmOver500(int pass, int km, double expected)
        {
            //Arrange
            IPriceCalculator c = new PriceCalculator();
            //Act
            double actualRes = c.TotalCost(pass, km);
            //Assert
            Assert.AreEqual(expected, actualRes);
        }
    }
}