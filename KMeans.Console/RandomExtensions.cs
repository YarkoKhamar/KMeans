using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KMeansConsole
{
    public static class RandomExtensions
    {
        
        public static double NextDouble(this Random random, double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
        public static double[][] GenerateRandom(int size)
        {
            var r = new Random();
            var result = Enumerable.Range(0, size).Select(x =>
                            Enumerable.Range(0, 2).Select(y => r.NextDouble(50.0, 250.0)).ToArray())
                        .ToArray();

            return result;
        }
    }
}
