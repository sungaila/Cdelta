#pragma warning disable IDE1006
using Microsoft.VisualStudio.TestTools.UnitTesting;
[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]

namespace Cdelta.Tests
{
    [TestClass]
    public class LowerCamelCaseTest
    {
        [TestMethod]
        public void Empty()
        {
            var machine = new LowerCamelCase();

            Assert.AreEqual(LowerCamelCaseMachine.State.Init, machine.CurrentState);
            Assert.IsFalse(machine.IsAcceptingState);
            Assert.IsFalse(machine.IsHalted);
        }

        [TestMethod]
        public void Cat()
        {
            var machine = new LowerCamelCase();

            foreach (var c in "Cat")
            {
                machine.Invoke(c);
            }

            Assert.AreEqual(LowerCamelCaseMachine.State.Init, machine.CurrentState);
            Assert.IsFalse(machine.IsAcceptingState);
            Assert.IsTrue(machine.IsHalted);
        }

        [TestMethod]
        public void CamelCase()
        {
            var machine = new LowerCamelCase();

            foreach (var c in "CamelCase")
            {
                machine.Invoke(c);
            }

            Assert.AreEqual(LowerCamelCaseMachine.State.Init, machine.CurrentState);
            Assert.IsFalse(machine.IsAcceptingState);
            Assert.IsTrue(machine.IsHalted);
        }

        [TestMethod]
        public void favoriteDVD()
        {
            var machine = new LowerCamelCase();

            foreach (var c in "favoriteDVD")
            {
                machine.Invoke(c);
            }

            Assert.AreEqual(LowerCamelCaseMachine.State.UpperChar, machine.CurrentState);
            Assert.IsFalse(machine.IsAcceptingState);
            Assert.IsTrue(machine.IsHalted);
        }

        [TestMethod]
        public void cat()
        {
            var machine = new LowerCamelCase();

            foreach (var c in "cat")
            {
                machine.Invoke(c);
            }

            Assert.AreEqual(LowerCamelCaseMachine.State.LowerChar, machine.CurrentState);
            Assert.IsTrue(machine.IsAcceptingState);
            Assert.IsFalse(machine.IsHalted);
        }

        [TestMethod]
        public void dogOwner()
        {
            var machine = new LowerCamelCase();

            foreach (var c in "dogOwner")
            {
                machine.Invoke(c);
            }

            Assert.AreEqual(LowerCamelCaseMachine.State.LowerChar, machine.CurrentState);
            Assert.IsTrue(machine.IsAcceptingState);
            Assert.IsFalse(machine.IsHalted);
        }

        [TestMethod]
        public void lowerCamelCase()
        {
            var machine = new LowerCamelCase();

            foreach (var c in "lowerCamelCase")
            {
                machine.Invoke(c);
            }

            Assert.AreEqual(LowerCamelCaseMachine.State.LowerChar, machine.CurrentState);
            Assert.IsTrue(machine.IsAcceptingState);
            Assert.IsFalse(machine.IsHalted);
        }

        private class LowerCamelCase : LowerCamelCaseMachine
        {
            protected override bool CanTransition_Init_LowerChar(char value) => char.IsLower(value);

            protected override bool CanTransition_LowerChar_LowerChar(char value) => char.IsLower(value);

            protected override bool CanTransition_LowerChar_UpperChar(char value) => char.IsUpper(value);

            protected override bool CanTransition_UpperChar_LowerChar(char value) => char.IsLower(value);
        }
    }
}
