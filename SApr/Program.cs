using System;
using SApr.models;

namespace SApr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LocalFile lf = new();
            Graph graph = new Graph();
            graph.Matrix = lf.ReadGraph();
            graph.CreateGraph();
            GenAlg v = new GenAlg(20, 1000, 0.95, 0.1, 0.1, graph);
            //Console.WriteLine(5);
            v.Go();
            Console.WriteLine(v.BestGen.Fitness);
        }
    }
}