using System;
using Functions;
using NUnit.Framework;

namespace FuncTest.FunctionTests
{
    internal class FunctionTest : TestFixture
    {
        [Test]
        public void ShouldReturnCorrrectFunctionValue()
        {
            var function = new Function(1, 3);
            var result = function.Calc(2);
            Assert.AreEqual(result, 8);
        }

        [Test]
        public void ShouldReturnCorrrectStringFunctionValue()
        {
            var function = new Function(1, 3);
            var stringValueResult = function.ToString();
            Assert.AreEqual(stringValueResult, "x ^ 3");
        }

        [Test]
        public void TestBigValues()
        {
            var expectedResult = Math.Pow(3, 20);
            var function = new Function(1, 20);
            var result = function.Calc(3);
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void TestFunctionWithCoeff()
        {
            var function = new Function(2, 4);
            var stringValueResult = function.ToString();
            Assert.AreEqual("2 * x ^ 4", stringValueResult);
        }

        [Test]
        public void ShouldReturnCorrectFunctionValWithCoeff()
        {
            var function = new Function(3, 3);
            var result = function.Calc(2);
            Assert.AreEqual(result, 24);
        }

        [Test]
        public void ShouldCalculateCorrectDerivate()
        {
            var function = new Function(2, 4);
            var derivateFunc = function.Derivative();
            Assert.AreEqual(derivateFunc.GetType(), typeof(Function));
            Assert.AreEqual(derivateFunc.ToString(), "8 * x ^ 3");
        }
}
}
