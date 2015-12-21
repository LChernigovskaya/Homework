using System;
namespace LocalNetwork
{
    /// <summary>
    /// Local network for using
    /// </summary>
    public class Network
    {
        private NetworkModel network;
        private Computer[] computers;
        private Algorithm algorithm;
        private int numberOfComps;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="numberOfComps">number of computers in the local network</param>
        /// <param name="infected">massive where show comp is infested or not</param>
        /// <param name="operationSystemOfComps">massive where show which OS the comp has</param>
        /// <param name="matrix">adjacency matrix where show computer connection</param>
        public Network(int numberOfComps, bool[] infected, string[] operationSystemOfComps, int[,] matrix)
        {
            this.numberOfComps = numberOfComps;
            this.algorithm = new AlgorithmNumberNeighbors();
            this.computers = new Computer[numberOfComps];
            for (int i = 0; i < numberOfComps; i++)
            {
                computers[i] = new Computer(OSConversion.Convert(operationSystemOfComps[i]), infected[i]);
            }
            this.network = new NetworkModel(numberOfComps, computers, matrix, algorithm);
        }

        /// <summary>
        /// moves to the next state of the network
        /// </summary>
        public void MakeStep()
        {
            network.MakeStep();
        }

        /// <summary>
        /// show the next state of the network
        /// </summary>
        /// <returns></returns>
        public string NetworkState()
        {
            string state = "Infected: ";
            computers = network.NetworkState();
            for (int i = 0; i < numberOfComps; i++)
            {
                if (computers[i].IsInfected)
                {
                    state += i + 1 + " ";
                }
            }
            return state;
        }
    }
}
