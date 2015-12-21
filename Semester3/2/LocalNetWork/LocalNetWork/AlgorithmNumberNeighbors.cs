using System.Collections.Generic;

namespace LocalNetwork
{
    /// <summary>
    /// Realise for algorithm
    /// </summary>
    class AlgorithmNumberNeighbors : Algorithm
    {
        public List<int> MakeInfection(int numberOfComputer, Computer[] computers, int[,] adjacencyMatrix)
        {
            List<int> infectedComps = new List<int>();
            int indexOfInfectingComp = 0;
            for (int i = 0; i < numberOfComputer; i++)
            {
                if (!computers[i].IsInfected)
                {
                    computers[i].InfectedNeighbors = 0;
                    for (int j = 0; j < numberOfComputer; j++)
                    {
                        if (adjacencyMatrix[i, j] == 1 && computers[j].IsInfected)
                        {
                            computers[i].InfectedNeighbors++;
                        }
                    }
                    computers[i].ProbabilityOfInfection = computers[i].OS.ProbabilityOfInfection * computers[i].InfectedNeighbors;
                    
                    if (computers[indexOfInfectingComp].ProbabilityOfInfection <= computers[i].ProbabilityOfInfection)
                    {
                        indexOfInfectingComp = i;
                    }
                }
            }
            if (computers[indexOfInfectingComp].ProbabilityOfInfection != 0.0)
            {
                for (int i = 0; i < numberOfComputer; i++)
                {
                    if (computers[indexOfInfectingComp].ProbabilityOfInfection == computers[i].ProbabilityOfInfection)
                    {
                        computers[i].IsInfected = true;
                        infectedComps.Add(i);
                    }
                }
            }
            return infectedComps;
        }
    }
}
