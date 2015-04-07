using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue;

namespace QueueTests
{
    [TestClass]
    public class QueueTests
    {
        private PriorityQueue queue;

        [TestInitialize]
        public void Initialize()
        {
            queue = new PriorityQueue();
        }

        [TestMethod]
        public void EnqueueTest()
        {
            queue.Enqueue(7, 1);
            Assert.AreEqual(1, queue.Size);
        }

        [TestMethod]
        public void DequeueTest()
        {
            queue.Enqueue(7, 1);
            Assert.AreEqual(queue.Dequeue(), 7);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DequeueExceptionTest()
        {
            queue.Dequeue();
        }

        [TestMethod]
        public void TwoElementsTest()
        {
            queue.Enqueue(7, 1);
            queue.Enqueue(5, 2);
            Assert.AreEqual(queue.Dequeue(), 5);
        }

        [TestMethod]
        public void TwoElementsWithEqualPriorityTest()
        {
            queue.Enqueue(7, 3);
            queue.Enqueue(6, 3);
            Assert.AreEqual(7, queue.Dequeue());
        }

        [TestMethod]
        public void TwoElements2Test()
        {
            queue.Enqueue(7, 3);
            queue.Enqueue(6, 45);
            Assert.AreEqual(6, queue.Dequeue());
            Assert.AreEqual(7, queue.Dequeue());
        }

        [TestMethod]
        public void RemoveDequeueTest()
        {
            queue.Enqueue(6, 2);
            queue.Enqueue(89, 67);
            queue.Enqueue(89, 65);
            queue.Dequeue();
            Assert.IsFalse(queue.Exists(89, 67));
        }
    }
}
