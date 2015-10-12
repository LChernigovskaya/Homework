using System.Collections.Generic;

namespace LocalNetwork
{
    /// <summary>
    /// The algorithm where state of the local network change
    /// </summary>
    interface Algorithm
    {
        /// <summary>
        /// How computers infect
        /// </summary>
        /// <param name="numberOfComputer">number of the computers</param>
        /// <param name="computers">the concrete computers</param>
        /// <param name="adjacencyMatrix">matrix, where computer connection</param>
        /// <returns>index of computers which will be infected</returns>
        List<int> MakeInfection(int numberOfComputer, Computer[] computers, int[,] adjacencyMatrix);
    }
}
