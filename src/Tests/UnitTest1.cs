using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cdelta.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        public class DummyClass
        {

        }

        private class TestImplementation : LowerCamelCaseMachine<DummyClass>
        {
            protected override bool CanTransitionInitLowerChar(DummyClass value) => false;

            protected override bool CanTransitionLowerCharUpperChar(DummyClass value) => false;

            protected override bool CanTransitionUpperCharLowerChar(DummyClass value) => false;

            protected override bool CanTransitionLowerCharLowerChar(DummyClass value) => false;

            protected override void EnterStateUpperChar()
            {
                base.EnterStateUpperChar();
            }

            protected override void EnterTransitionInitLowerChar()
            {
                base.EnterTransitionInitLowerChar();
            }

            protected override void ExitStateLowerChar()
            {
                base.ExitStateLowerChar();
            }
        }
    }
}
