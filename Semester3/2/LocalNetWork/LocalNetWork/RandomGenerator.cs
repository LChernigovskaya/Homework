using System;

namespace LocalNetwork
{
    public class RandomGenerator : Generator
    {
        private Random random = new Random();

        public double GetNumber() => random.NextDouble();
    }
}
