using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;
using NUnit.Framework;

namespace FuncTest.FunctionTests
{
    public class ConstantOperationTests : TestFixture
    {
        #region fields
        private Constant _constant;
        private double _dobleVal;
        #endregion

        protected override void OnSetup()
        {
            _constant = new Constant(4);
            _dobleVal = 2;
        }


        [Test]
        public void ShouldReturnCorrectValueForConstantSumOperations()
        {
            var result = _constant + _dobleVal;
            Assert.AreEqual(result.GetType(), typeof(Constant));
            Assert.AreEqual(6, ((Constant)result).Calc());
        }

        [Test]
        public void ShouldReturnCorrectValueForConstantSubstractOperations()
        {
            var result = _constant - _dobleVal;
            Assert.AreEqual(result.GetType(), typeof(Constant));
            Assert.AreEqual(2, ((Constant)result).Calc());
        }

        [Test]
        public void ShouldReturnCorrectValueForConstantMultipleOperations()
        {
            var result = _constant * _dobleVal;
            Assert.AreEqual(result.GetType(), typeof(Constant));
            Assert.AreEqual(8, ((Constant)result).Calc());
        }

        [Test]
        public void ShouldReturnCorrectValueForConstantDivideOperations()
        {
            var result = _constant / _dobleVal;
            Assert.AreEqual(result.GetType(), typeof(Constant));
            Assert.AreEqual(2, ((Constant)result).Calc());
        }

        [Test]
        public void ShouldReturnCorrectValueForConstantSumOperations1()
        {
            var result =  _dobleVal +_constant;
            Assert.AreEqual(result.GetType(), typeof(Constant));
            Assert.AreEqual(6, ((Constant)result).Calc());
        }

        [Test]
        public void ShouldReturnCorrectValueForConstantSubstractOperations1()
        {
            var result = _dobleVal - _constant;
            Assert.AreEqual(result.GetType(), typeof(Constant));
            Assert.AreEqual(-2, ((Constant)result).Calc());
        }

        [Test]
        public void ShouldReturnCorrectValueForConstantMultipleOperations1()
        {
            var result = _dobleVal * _constant;
            Assert.AreEqual(result.GetType(), typeof(Constant));
            Assert.AreEqual(8,((Constant)result).Calc());
        }

        [Test]
        public void ShouldReturnCorrectValueForConstantDivideOperations1()
        {
            var result = _dobleVal / _constant;
            Assert.AreEqual(result.GetType(), typeof(Constant));
            Assert.AreEqual(0.5, ((Constant)result).Calc());
        }
    }
}
