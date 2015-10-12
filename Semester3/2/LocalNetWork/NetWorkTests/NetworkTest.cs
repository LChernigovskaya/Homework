using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocalNetwork;

namespace NetworkTests
{
    [TestClass]
    public class NetworkTest
    {
        private Network network;
        private int[,] matrixOfComps;

        [TestMethod]
        public void OneComputerTest()
        {
            bool[] infected = { true };
            string[] os = { "linux" };
            matrixOfComps = new int[,] { {1} };
            network = new Network(1, infected, os, matrixOfComps);
            Assert.AreEqual(network.NetworkState(), "Infected: 1 ");
        }
        
        [TestMethod]
        public void TwoComputerTest()
        {
            bool[] infected = {false, true};
            string[] os = {"linux", "windows"};
            matrixOfComps = new int[,] { {0, 1}, {1, 0} };
            network = new Network(2, infected, os, matrixOfComps);
            Assert.AreEqual(network.NetworkState(), "Infected: 2 ");
        }

        [TestMethod]
        public void MakeStepTest()
        {
            bool[] infected = { false, true };
            string[] os = { "linux", "windows" };
            matrixOfComps = new int[,] { { 0, 1 }, { 1, 0 } };
            network = new Network(2, infected, os, matrixOfComps);
            network.MakeStep();
            Assert.AreEqual(network.NetworkState(), "Infected: 1 2 ");
        }

        [TestMethod]
        public void ThreeComputerTest()
        {
            bool[] infected = { false, true, false };
            string[] os = { "linux", "windows", "mac" };
            matrixOfComps = new int[,] { { 0, 1, 0 }, { 1, 0, 1 }, {0, 1, 0} };
            network = new Network(3, infected, os, matrixOfComps);
            Assert.AreEqual(network.NetworkState(), "Infected: 2 ");
            network.MakeStep();
            Assert.AreEqual(network.NetworkState(), "Infected: 2 3 ");
            network.MakeStep();
            Assert.AreEqual(network.NetworkState(), "Infected: 1 2 3 ");
        }

        [TestMethod]
        public void FiveComputerTest()
        {
            bool[] infected = { false, false, true, false, false };
            string[] os = { "linux", "windows", "mac", "windows", "linux" };
            matrixOfComps = new int[,] { { 0, 1, 0, 0, 0 }, { 1, 0, 1, 0, 0 }, { 0, 1, 0, 1, 0}, {0, 0, 1, 0, 1}, {1, 0, 0, 1, 0} };
            network = new Network(5, infected, os, matrixOfComps);
            Assert.AreEqual(network.NetworkState(), "Infected: 3 ");
            network.MakeStep();
            Assert.AreEqual(network.NetworkState(), "Infected: 2 3 4 ");
            network.MakeStep();
            Assert.AreEqual(network.NetworkState(), "Infected: 1 2 3 4 5 ");
        }
    }
}
