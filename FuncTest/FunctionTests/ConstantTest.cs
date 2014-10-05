using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;
using NUnit.Framework;

namespace FuncTest.FunctionTests
{
    public class ConstantTest :TestFixture
    {
        [Test]
        public void ConstantStringTest()
        {
            var constant = new Constant(22.234567);
            Assert.AreEqual(constant.ToString(), "22.234567");
        }
    }
}
