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
            graph.WriteVertexs();
            graph.WriteEdges();
            graph.WriteMatrix();
            FormFamOfSets g = new FormFamOfSets();
            g.GetSet(graph);
            var s = lf.ReadSplit();
            /*BuildRanMatrix s = new BuildRanMatrix();
            s.WriteMatix();*/
        }
    }
}