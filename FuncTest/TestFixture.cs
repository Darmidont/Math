using NUnit.Framework;

namespace FuncTest
{
    public abstract class TestFixture
    {
        protected virtual void OnFixtureSetup()
        {
        }

        protected virtual void OnFixtureTeardown()
        {
        }

        protected virtual void OnSetup()
        {
        }

        protected virtual void OnTeardown()
        {
        }

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            OnFixtureSetup();
        }

        [TestFixtureTearDown]
        public void FixtureTeardown()
        {
            OnFixtureTeardown();
        }

        [SetUp]
        public void Setup()
        {
            OnSetup();
        }

        [TearDown]
        public void Teardown()
        {
            OnTeardown();
        }
    }
}