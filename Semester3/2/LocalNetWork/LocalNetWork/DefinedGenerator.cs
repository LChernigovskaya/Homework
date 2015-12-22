namespace LocalNetwork
{
    /// <summary>
    /// Not randomly number generator for tests
    /// </summary>
    public class DefinedGenerator : Generator
    {
        private double[] arrayOfRandom;
        private int pointer = -1;

        public DefinedGenerator(double[] array)
        {
            arrayOfRandom = array;
        }

        public double GetNumber()
        {
            pointer++;

            if (pointer == arrayOfRandom.Length)
            {
                pointer = 0;
            }
            
            return arrayOfRandom[pointer];
        }
    }
}
