using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace KMeansConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            double[][] rawData = new double[20][];
            int choice = 0;
            Console.WriteLine("Make your choice:");
            Console.WriteLine("1 - read from file");
            Console.WriteLine("2 - generate");
            choice = int.Parse(Console.ReadLine());
            int len = 0;
            if(choice == 2)
            {
                Console.WriteLine("Enter length of data:");
                len = int.Parse(Console.ReadLine());
            }
            switch(choice)
            {
                case 1: rawData = HelpersDisplay.LoadFromFile(); break;
                case 2: rawData = RandomExtensions.GenerateRandom(len); break;
            }
            //rawData = HelpersDisplay.LoadFromFile();
            //rawData = RandomExtensions.GenerateRandom(20);

            Console.WriteLine("Raw unclustered data:");
            //Console.WriteLine("    Height Weight");
            Console.WriteLine("-------------------");
            HelpersDisplay.ShowData(rawData, 1, true, true);

            int numClusters = 0;
            Console.Write("Setting numClusters to ");
            numClusters = int.Parse(Console.ReadLine());
            Console.Write(numClusters);
            Console.WriteLine();
            int[] clustering = Cluster.ClusterMethod(rawData, numClusters);

            Console.WriteLine("K-means clustering complete");

            Console.WriteLine("Final clustering in internal form:");
            HelpersDisplay.ShowVector(clustering, true);

            Console.WriteLine("Raw data by cluster:");
            HelpersDisplay.ShowClustered(rawData, clustering, numClusters, 1);

            //Console.WriteLine("End k-means clustering demo");

            Console.ReadLine();
        }
    }
}
