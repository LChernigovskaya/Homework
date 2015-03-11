using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniqueListNamespace;

namespace UniqueListTests
{
    [TestClass]
    public class UniqueListTest
    {
        private UniqueList list;

        [TestInitialize]
        public void Initialize()
        {
            list = new UniqueList();
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionAdd))]
        public void AddExistingElementTest()
        {
            list.AddInOrder(4);
            list.AddInOrder(4);
        }

        [TestMethod]
        [ExpectedException(typeof(ExceptionRemove))]
        public void RemoveNonexistentTest()
        {
            list.RemoveElement(8);
        }
    }
}
