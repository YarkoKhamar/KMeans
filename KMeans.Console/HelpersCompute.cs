using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KMeansConsole
{
    public class HelpersCompute
    {
        public static double[][] Normalize(double[][] rawData)
        {
            double[][] result = new double[rawData.Length][];
            for (int i = 0; i < rawData.Length; ++i)
            {
                result[i] = new double[rawData[i].Length];
                Array.Copy(rawData[i], result[i], rawData[i].Length);
            }

            for (int j = 0; j < result[0].Length; ++j)
            {
                double colSum = 0.0;
                for (int i = 0; i < result.Length; ++i)
                {
                    colSum += result[i][j];
                }
                double mean = colSum / result.Length;

                double sum = 0.0;
                for (int i = 0; i < result.Length; ++i)
                {
                    sum += (result[i][j] - mean) * (result[i][j] - mean);
                }

                double sd = sum / result.Length;
                for (int i = 0; i < result.Length; ++i)
                {
                    result[i][j] = (result[i][j] - mean) / sd;
                }
            }

            return result;
        }

        public static int[] InitClustering(int numTuples, int numClusters, int seed)
        {
            Random random = new Random();

            int[] clustering = new int[numTuples];

            for (int i = 0; i < numClusters; ++i)
            {
                clustering[i] = i;
            }

            for (int i = numClusters; i < clustering.Length; ++i)
            {
                clustering[i] = random.Next(0, numClusters);
            }

            return clustering;
        }

        public static bool UpdateMeans(double[][] data, int[] clustering, double[][] means)
        {
            int numClusters = means.Length;
            int[] clusterCounts = new int[numClusters];
            for (int i = 0; i < data.Length; ++i)
            {
                int cluster = clustering[i];
                ++clusterCounts[cluster];
            }

            for (int k = 0; k < numClusters; ++k)
            {
                if (clusterCounts[k] == 0)
                {
                    return false;
                }
            }

            for (int k = 0; k < means.Length; ++k)
            {
                for (int j = 0; j < means[k].Length; ++j)
                {
                    means[k][j] = 0.0;
                }
            }

            for (int i = 0; i < data.Length; ++i)
            {
                int cluster = clustering[i];
                for (int j = 0; j < data[i].Length; ++j)
                {
                    means[cluster][j] += data[i][j];
                }
            }

            for (int k = 0; k < means.Length; ++k)
            {
                for (int j = 0; j < means[k].Length; ++j)
                {
                    means[k][j] /= clusterCounts[k];
                }
            }

            return true;
        }

        public static double[][] Allocate(int numClusters, int numColumns)
        {
            double[][] result = new double[numClusters][];
            for (int k = 0; k < numClusters; ++k)
            {
                result[k] = new double[numColumns];
            }

            return result;
        }

        public static double Distance(double[] tuple, double[] mean)
        {
            double sumSquaredDiffs = 0.0;
            for (int j = 0; j < tuple.Length; ++j)
            {
                sumSquaredDiffs += Math.Pow((tuple[j] - mean[j]), 2);
            }

            return Math.Sqrt(sumSquaredDiffs);
        }

        public static int MinIndex(double[] distances)
        {
            int indexOfMin = 0;
            double smallDist = distances[0];
            for (int k = 0; k < distances.Length; ++k)
            {
                if (distances[k] < smallDist)
                {
                    smallDist = distances[k];
                    indexOfMin = k;
                }
            }

            return indexOfMin;
        }
    }
}
