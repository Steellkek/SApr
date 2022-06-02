namespace SApr.models;

public class Graph
{
    public int[,] Matrix
    {
        get { return new int[,] { }; }
    }
    public List<Edge> Edges = new();
    public List<Vertex> Vertexs=new();
}