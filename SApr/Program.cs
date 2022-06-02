using System;
using SApr.models;

namespace SApr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph g = new();
            g.AddVertex(6);
            g.AddVertex(5);
            g.AddVertex(5);
            Console.WriteLine(g.Vertexs[0].Number);
            Console.WriteLine(g.Vertexs[1].Number);
            Console.WriteLine(g.Vertexs[2].Number);
            g.AddEdge(g.Vertexs[0], g.Vertexs[0], 8);
            g.WriteVertex();
        }
    }
}