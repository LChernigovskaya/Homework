using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackNamespace;

namespace StackTests
{
    [TestClass]
    public class StringStackTests
    {
        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack<string>();
        }

        [TestMethod]
        public void PushTest()
        {
            stack.Push("1");
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void PopTest()
        {
            stack.Push("1");
            Assert.AreEqual("1", stack.Pop());
        }

        [TestMethod]
        public void PopRemoveTest()
        {
            stack.Push("1");
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void TwoElementsPopTest()
        {
            stack.Push("1");
            stack.Push("2");
            Assert.AreEqual("2", stack.Pop());
            Assert.AreEqual("1", stack.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PopFromEmptyStack()
        {
            stack.Pop();
        }

        private Stack<string> stack;
    }
}
