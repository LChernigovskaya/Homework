using System.Collections.Generic;

namespace LocalNetwork
{
    /// <summary>
    /// Network model
    /// </summary>
    class NetworkModel
    {
        private Computer[] computers;
        private int[,] compsMatrix;
        private Generator generator;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="numberOfComps">number of computers in the local network</param>
        /// <param name="comps">the concrete computers</param>
        /// <param name="matrix">adjacency matrix where show computer connection</param>
        public NetworkModel(Computer[] comps, int[,] matrix, Generator numberGenerator)
        {
            this.computers = comps;
            this.compsMatrix = matrix;
            this.generator = numberGenerator;
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
            List<int> indexInfected = Algorithm.MakeInfection(this.computers, this.compsMatrix, ref this.generator);
            foreach (var index in indexInfected)
            {
                computers[index].IsInfected = true;
            }
        }
    }
}
