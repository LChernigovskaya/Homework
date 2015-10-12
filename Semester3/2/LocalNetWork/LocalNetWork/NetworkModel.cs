using System.Collections.Generic;

namespace LocalNetwork
{
    /// <summary>
    /// Network model
    /// </summary>
    class NetworkModel
    {
        private int numberOfComputer;
        private Computer[] computers;
        private int[,] compsMatrix;
        private Algorithm algorithm;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="numberOfComps">number of computers in the local network</param>
        /// <param name="comps">the concrete computers</param>
        /// <param name="matrix">adjacency matrix where show computer connection</param>
        /// <param name="algorithm">the algorithm where state of the local network change</param>
        public NetworkModel(int numberOfComps, Computer[] comps, int[,] matrix, Algorithm algorithm)
        {
            this.numberOfComputer = numberOfComps;
            this.computers = comps;
            this.compsMatrix = matrix;
            this.algorithm = algorithm;
        }

        /// <summary>
        /// show the next state of the network
        /// </summary>
        /// <returns></returns>
        public Computer[] NetworkState()
        {
            return computers;
        }

        /// <summary>
        /// moves to the next state of the network
        /// </summary>
        public void MakeStep()
        {
            List<int> compsInfected = new List<int>();
            compsInfected = algorithm.MakeInfection(this.numberOfComputer, this.computers, this.compsMatrix);
            foreach (int element in compsInfected)
            {
                computers[element].IsInfected = true;
            }
        }
    }
}
