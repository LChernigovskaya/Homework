
namespace Robots
{
    /// <summary>
    /// Class which realised algorithm, which checked teleportations, destroying all robots exist or not
    /// </summary>
    public class RobotsGraph
    {
        /// <param name="positions">positions, where robots are there</param>
        public RobotsGraph(int numberOfVertices, int[] positions)
        {
            this.numberOfVertices = numberOfVertices;
            this.matrix = new bool[numberOfVertices, numberOfVertices];
            for (int i = 0; i < numberOfVertices; i++)
                for (int j = 0; j < numberOfVertices; j++)
                {
                    matrix[i, j] = false;
                }
            this.robotsPosition = new bool[numberOfVertices];

            for (int i = 0; i < numberOfVertices; i++)
            {
                this.robotsPosition[i] = false;
            }
            for (int j = 0; j < positions.Length; j++)
            {
                this.robotsPosition[positions[j]] = true;
            }
            this.wasVisited = new bool[numberOfVertices];
            for (int i = 0; i < numberOfVertices; i++)
            {
                wasVisited[i] = false;
            }
        }

        /// <summary>
        /// Connect two verteces
        /// </summary>
        public void ConnectVerteces(int first, int second)
        {
            matrix[first, second] = true;
            matrix[second, first] = true;
        }

        /// <summary>
        /// If this method finds the robot, which doesn't face other robot at teleportations, return false
        /// </summary>
        public bool CheckExistOrNot()
        {
            for (int i = 0; i < numberOfVertices; i++)
            {
                if (!wasVisited[i] && robotsPosition[i])
                {
                    int numberConected = 0;
                    FindConnectedRobots(i, ref numberConected);
                    if (numberConected == 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void FindConnectedRobots(int vertex, ref int conected)
        {
            if (wasVisited[vertex])
            {
                return;
            }

            if (robotsPosition[vertex])
            {
                conected++;
            }
            wasVisited[vertex] = true;
            for (int i = 0; i < numberOfVertices; i++)
            {
                if (matrix[vertex, i])
                {
                    for (int j = 0; j < numberOfVertices; j++)
                    {
                        if (matrix[i, j])
                        {
                            FindConnectedRobots(j, ref conected);
                        }
                    }
                }
            }
        }

        private int numberOfVertices;
        private bool[,] matrix;
        private bool[] robotsPosition;
        private bool[] wasVisited;
    }
}
