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

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="infected">array where show comp is infested or not</param>
        /// <param name="operationSystemOfComps">array where show which OS the comp has</param>
        /// <param name="matrix">adjacency matrix where show computer connection</param>
        public Network(bool[] infected, string[] operationSystemOfComps, int[,] matrix, Generator generator)
        {
            int numberOfComps = infected.Length;
            this.computers = new Computer[numberOfComps];
            for (int i = 0; i < numberOfComps; i++)
            {
                computers[i] = new Computer(OSConversion.Convert(operationSystemOfComps[i]), infected[i]);
            }
            this.network = new NetworkModel(computers, matrix, generator);
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
            for (int i = 0; i < computers.Length; i++)
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
