using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tree;

namespace TreeTests
{
    [TestClass]
    public class TreeTest
    {
        private Tree<int> tree;

        [TestInitialize]
        public void Initialize()
        {
            tree = new BinaryTree<int>();
        }

        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsTrue(tree.IsEmpty());
        }

        [TestMethod]
        public void IsNotEmptyTest()
        {
            tree.Add(8);
            Assert.IsFalse(tree.IsEmpty());
        }

        [TestMethod]
        public void ExistsTest()
        {
            tree.Add(78);
            Assert.IsTrue(tree.IsExists(78));
        }

        [TestMethod]
        public void NotExistsEmptyTest()
        {
            Assert.IsFalse(tree.IsExists(9));
        }

        [TestMethod]
        public void NotExistsTest()
        {
            tree.Add(89);
            Assert.IsFalse(tree.IsExists(5));
        }

        [TestMethod]
        public void AddTest()
        {
            tree.Add(9);
            Assert.IsTrue(tree.IsExists(9));
        }

        [TestMethod]
        public void AddSeveralElementsTest()
        {
            tree.Add(8);
            tree.Add(7);
            tree.Add(10);
            Assert.IsTrue(tree.IsExists(7));
            Assert.IsTrue(tree.IsExists(8));
            Assert.IsTrue(tree.IsExists(10));
        }

        [TestMethod]
        public void RemoveRootTest()
        {
            tree.Add(8);
            Assert.IsTrue(tree.IsExists(8));
            tree.Remove(8);
            Assert.IsFalse(tree.IsExists(8));
        }

        [TestMethod]
        public void RemoveLeaf()
        {
            tree.Add(9);
            tree.Add(8);
            tree.Add(11);
            tree.Remove(8);
            Assert.IsFalse(tree.IsExists(8));
        }

        [TestMethod]
        public void RemoveRootWithOneChild()
        {
            tree.Add(10);
            tree.Add(8);
            tree.Add(9);
            tree.Add(7);
            tree.Remove(10);
            Assert.IsFalse(tree.IsExists(10));
        }

        [TestMethod]
        public void RemoveWithSeveralElementsTest()
        {
            tree.Add(9);
            tree.Add(78);
            tree.Add(10);
            tree.Add(1);
            tree.Add(2);
            tree.Add(100);
            tree.Remove(78);
            tree.Remove(1);
            Assert.IsFalse(tree.IsExists(78));
            Assert.IsFalse(tree.IsExists(1));
            Assert.IsTrue(tree.IsExists(9));
            Assert.IsTrue(tree.IsExists(10));
            Assert.IsTrue(tree.IsExists(2));
            Assert.IsTrue(tree.IsExists(100));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void RemoveFromEmtyTree()
        {
            tree.Remove(8);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddExistsValue()
        {
            tree.Add(7);
            tree.Add(7);
        }

        [TestMethod]
        public void PrintTest()
        {
            tree.Add(8);
            tree.Add(11);
            tree.Add(89);
            tree.Add(7);
            tree.Add(56);
            Assert.AreEqual(tree.PrintElementsOfTree(), "7 8 11 56 89 ");
        }

        [TestMethod]
        public void ForEachTest()
        {
            for (int i = 0; i < 10; i += 2)
            {
                tree.Add(i);
            }

            int j = 0;

            foreach (int value in tree)
            {
                Assert.IsTrue(value == j);
                j += 2;
            }
        }


        [TestMethod]
        public void EnumaratorTest()
        {
            for (int i = 0; i < 10; i += 2)
            {
                tree.Add(i);
            }

            var enumerator = tree.GetEnumerator();
            string valueList = "";

            while (enumerator.MoveNext())
            {
                valueList += enumerator.Current;
            }
            Assert.AreEqual(valueList, "02468");
        }

        [TestMethod]
        public void EnumaratorResetTest()
        {
            for (int i = 0; i < 10; i += 2)
            {
                tree.Add(i);
            }

            var enumerator = tree.GetEnumerator();
            string valueList = "";

            while (enumerator.MoveNext())
            {
                valueList += enumerator.Current;
            }

            enumerator.Reset();

            while (enumerator.MoveNext())
            {
                valueList += enumerator.Current;
            }
            Assert.AreEqual(valueList, "0246802468");
        }
    }
}
