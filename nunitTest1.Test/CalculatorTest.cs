using System;
using NUnit.Framework;

namespace nunitTest1.Test
{
    [TestFixture]
    public class CalculatorTest : IDisposable
    {

        Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }
        
        [Test]
        public void Test_Addition_With_Valid_Integers()
        {
            var result = calculator.Addition(7, 2);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Test_Subtraction_Argument_Exception() 
        {
            Assert.Catch<SystemException>(() => calculator.Subtraction(6,9));

        }

        [TestCase(6,2,8)]
        [TestCase(1,9,10)]
        public void Test_Addition_Multiple(int first, int second, int result)
        {
            var calculated = calculator.Addition(first, second);
            Assert.AreEqual(result, calculated);

        }

        [Ignore("Ignore Test")]
        public void Test_To_Ignore()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
