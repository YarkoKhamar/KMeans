using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KMeansConsole
{
    public class HelpersDisplay
    {
        public static void ShowData(double[][] data, int decimals, bool indices, bool newLine)
        {
            for (int i = 0; i < data.Length; ++i)
            {
                if (indices)
                {
                    Console.Write(i.ToString().PadLeft(3) + " ");
                }
                for (int j = 0; j < data[i].Length; ++j)
                {
                    if (data[i][j] >= 0.0)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(data[i][j].ToString("F" + decimals) + " ");
                }

                Console.WriteLine("");
            }

            if (newLine)
            {
                Console.WriteLine("");
            }
        }

        public static void ShowVector(int[] vector, bool newLine)
        {
            for (int i = 0; i < vector.Length; ++i)
            {
                Console.Write(vector[i] + " ");
            }
            if (newLine)
            {
                Console.WriteLine("\n");
            }
        }

        public static void ShowClustered(double[][] data, int[] clustering, int numClusters, int decimals)
        {
            for (int k = 0; k < numClusters; ++k)
            {
                Console.WriteLine("===================");
                for (int i = 0; i < data.Length; ++i)
                {
                    int clusterID = clustering[i];
                    if (clusterID != k)
                    {
                        continue;
                    }
                    Console.Write(i.ToString().PadLeft(3) + " ");
                    for (int j = 0; j < data[i].Length; ++j)
                    {
                        if (data[i][j] >= 0.0)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(data[i][j].ToString("F" + decimals) + " ");
                    }

                    Console.WriteLine("");
                }

                Console.WriteLine("===================");
            }
        }

        public static double[][] LoadFromFile()
        {
            return File.ReadLines("dataEx1.txt")
                     .Select(l => l.Split(' ').Select(Convert.ToDouble).ToArray())
                     .ToArray();
        }
        public static double[][] LoadFromFilePath(string path)
        {
            return File.ReadLines(path)
                     .Select(l => l.Split(' ').Select(Convert.ToDouble).ToArray())
                     .ToArray();
        }
    }
}
