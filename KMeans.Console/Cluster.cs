using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KMeansConsole
{
    public class Cluster
    {
        public static int[] ClusterMethod(double[][] rawData, int numClusters)
        {
            double[][] data = HelpersCompute.Normalize(rawData);
            //double[][] data = rawData;
            bool changed = true;
            bool success = true;

            int[] clustering = HelpersCompute.InitClustering(data.Length, numClusters, 0);
            double[][] means = HelpersCompute.Allocate(numClusters, data[0].Length);

            int maxCount = data.Length*100;
            int ct = 0;

            while (changed == true && success == true && ct < maxCount)
            {
                ++ct;
                success = HelpersCompute.UpdateMeans(data, clustering, means);
                changed = UpdateClustering(data, clustering, means);
            }

            return clustering;
        }
        private static bool UpdateClustering(double[][] data, int[] clustering, double[][] means)
        {
            int numClusters = means.Length;
            bool changed = false;

            int[] newClustering = new int[clustering.Length];
            Array.Copy(clustering, newClustering, clustering.Length);

            double[] distances = new double[numClusters];

            for (int i = 0; i < data.Length; ++i)
            {
                for (int k = 0; k < numClusters; ++k)
                {
                    distances[k] = HelpersCompute.Distance(data[i], means[k]);
                }

                int newClusterID = HelpersCompute.MinIndex(distances);

                if (newClusterID != newClustering[i])
                {
                    changed = true;
                    newClustering[i] = newClusterID;
                }
            }

            if (changed == false)
            {
                return false;
            }

            int[] clusterCounts = new int[numClusters];
            for (int i = 0; i < data.Length; ++i)
            {
                int cluster = newClustering[i];
                ++clusterCounts[cluster];
            }

            for (int k = 0; k < numClusters; ++k)
            {
                if (clusterCounts[k] == 0)
                {
                    return false;
                }
            }

            Array.Copy(newClustering, clustering, newClustering.Length);

            return true;
        }
    }
}
