using System.Collections.Generic;

namespace LocalNetwork
{
    /// <summary>
    /// The algorithm where state of the local network change
    /// </summary>
    static class Algorithm
    {
        /// <summary>
        /// How computers infect
        /// </summary>
        /// <param name="computers">the concrete computers</param>
        /// <param name="adjacencyMatrix">matrix, where computer connection</param>
        /// <returns>index of computers which will be infected</returns>
        public static List<int> MakeInfection(Computer[] computers, int[,] adjacencyMatrix, Generator numberGenerator)
        {
            List<int> indexInfected = new List<int>();
            double number = numberGenerator.GetNumber();
            for (int i = 0; i < computers.Length; i++)
            {
                if (computers[i].IsInfected)
                {
                    for (int j = 0; j < computers.Length; j++)
                    {
                        if (adjacencyMatrix[i, j] == 1 && computers[j].TryInfect(number))
                        {
                            indexInfected.Add(j);
                        }
                    }
                }
            }

            return indexInfected;
        }
    }
}
