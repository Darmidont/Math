using System;
using Functions;
using NUnit.Framework;

namespace FuncTest.FunctionTests
{
    class FunctionTest : TestFixture
    {
        [Test]
        public void ShouldReturnCorrrectFunctionValue()
        {
            var function = new Function(3);
            var result = function.Calc(2);
            Assert.AreEqual(result, 8);
        }

        [Test]
        public void ShouldReturnCorrrectStringFunctionValue()
        {
            var function = new Function(3);
            var stringValueResult = function.ToString();
            Assert.AreEqual(stringValueResult, "x ^ 3");
        }

        [Test]
        public void TestBigValues()
        {
            var expectedResult = Math.Pow(3, 20);
            var function = new Function(20);
            var result = function.Calc(3);
            Assert.AreEqual(result, expectedResult);
        }
    }
}
