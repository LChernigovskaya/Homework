using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SetNamespace;

namespace SetTests
{
    [TestClass]
    public class SetTest
    {
        private Set<int> set;

        [TestInitialize]
        public void Initialize()
        {
            set = new Set<int>();
        }

        [TestMethod]
        public void ExistsTest()
        {
            Assert.IsFalse(set.Exists(5));
        }

        [TestMethod]
        public void AddTest()
        {
            set.Add(7);
            Assert.IsTrue(set.Exists(7));
            Assert.IsFalse(set.Exists(5));
        }

        [TestMethod]
        public void AddSeveralElements()
        {
            set.Add(7);
            set.Add(6);
            Assert.IsTrue(set.Exists(6));
            Assert.IsTrue(set.Exists(7));
        }

        [TestMethod]
        public void RemoveTest()
        {
            set.Add(11);
            set.Add(11);
            Assert.IsTrue(set.Exists(11));
            set.RemoveElement(11);
            Assert.IsFalse(set.Exists(11));
        }

        [TestMethod]
        public void UnionTest()
        {
            Set<int> secondSet = new Set<int>() { 1, 2, 3 };
            set.Add(2);
            set.Add(5);
            set.Add(7);

            Assert.IsTrue(set.Union(secondSet).Exists(1));
            Assert.IsTrue(set.Union(secondSet).Exists(2));
            Assert.IsTrue(set.Union(secondSet).Exists(3));
            Assert.IsTrue(set.Union(secondSet).Exists(5));
            Assert.IsTrue(set.Union(secondSet).Exists(7));
        }

        [TestMethod]
        public void IntersectionTest()
        {
            Set<int> secondSet = new Set<int>() { 1, 3, 5 };
            set.Add(1);
            set.Add(2);
            set.Add(3);

            Assert.IsTrue(set.Intersection(secondSet).Exists(1));
            Assert.IsTrue(set.Intersection(secondSet).Exists(3));
            Assert.IsFalse(set.Intersection(secondSet).Exists(2));
            Assert.IsFalse(set.Intersection(secondSet).Exists(5));
        }
    }
}
