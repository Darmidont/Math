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
            
            Assert.AreEqual(((Constant)result).Calc(), 6);
        }

        [Test]
        public void ShouldReturnCorrectValueForConstantSubstractOperations()
        {
            string dd = string.Empty;
        }

        [Test]
        public void ShouldReturnCorrectValueForConstantMultipleOperations()
        {
        }

        [Test]
        public void ShouldReturnCorrectValueForConstantDivideOperations()
        {

        }

        //
        [Test]
        public void ShouldReturnCorrectValueForConstantSumOperations1()
        {

        }

        [Test]
        public void ShouldReturnCorrectValueForConstantSubstractOperations1()
        {

        }

        [Test]
        public void ShouldReturnCorrectValueForConstantMultipleOperations1()
        {

        }

        [Test]
        public void ShouldReturnCorrectValueForConstantDivideOperations1()
        {

        }
    }
}
