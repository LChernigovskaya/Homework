using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robots;

namespace RobotsTest
{
    [TestClass]
    public class RobotsTest
    {
        private RobotsGraph robots;
        private int[] position;

        [TestMethod]
        public void TrueTest()
        {
            position = new int[] { 0, 2 };
            robots = new RobotsGraph(4, position);
            robots.ConnectVerteces(1, 0);
            robots.ConnectVerteces(1, 2);
            robots.ConnectVerteces(1, 3);
            Assert.IsTrue(robots.CheckExistOrNot());
        }

        [TestMethod]
        public void FalseTest()
        {
            position = new int[] { 1, 2 };
            robots = new RobotsGraph(4, position);
            robots.ConnectVerteces(0, 1);
            robots.ConnectVerteces(1, 2);
            robots.ConnectVerteces(2, 3);
            robots.ConnectVerteces(3, 0);
            Assert.IsFalse(robots.CheckExistOrNot());
        }

        [TestMethod]
        public void BiggerGraphTest()
        {
            position = new int[] { 2, 4, 7 };
            robots = new RobotsGraph(8, position);
            robots.ConnectVerteces(0, 1);
            robots.ConnectVerteces(1, 2);
            robots.ConnectVerteces(1, 4);
            robots.ConnectVerteces(1, 6);
            robots.ConnectVerteces(2, 3);
            robots.ConnectVerteces(3, 4);
            robots.ConnectVerteces(4, 5);
            robots.ConnectVerteces(5, 6);
            robots.ConnectVerteces(6, 7);
            Assert.IsFalse(robots.CheckExistOrNot());
        }
    }
}
