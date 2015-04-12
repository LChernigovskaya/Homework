using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
using System.IO;

namespace TreeTests
{
    [TestClass]
    public class TreeTest
    {
        private Tree tree;
        private StreamWriter stWriter;
        private StreamReader stReader;

        [TestInitialize]
        public void Initialize()
        {
            tree = new Tree();
            stWriter = new StreamWriter("calculate.txt");
        }

        [TestMethod]
        public void AddTest()
        {
            stWriter.Write("+ 1 2");
            stWriter.Close();

            stReader = new StreamReader("calculate.txt");
            tree.PutInTree(stReader, tree);
        }

        [TestMethod]
        [ExpectedException(typeof(TreeException))]
        public void ExeptionAddTest()
        {
            stWriter.Write("+ 1 2 1");
            stWriter.Close();

            stReader = new StreamReader("calculate.txt");
            tree.PutInTree(stReader, tree);
        }

        [TestMethod]
        public void ResultTest()
        {
            stWriter.Write("(/ (* (- 5 2) (+ 1 1) ) 6)");
            stWriter.Close();
            
            stReader = new StreamReader("calculate.txt");
            tree.PutInTree(stReader, tree);
            Assert.AreEqual(tree.Result(), 1);
        }

        [TestMethod]
        [ExpectedException(typeof(TreeException))]
        public void DevisionByZero()
        {
            stWriter.Write("/ 1 0");
            stWriter.Close();

            stReader = new StreamReader("calculate.txt");
            tree.PutInTree(stReader, tree);
            tree.Result();
        }

        [TestCleanup]
        public void CleanUp()
        {
            stReader.Close();
        }
    }
}
