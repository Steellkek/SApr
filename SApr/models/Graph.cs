namespace SApr.models;

public class Graph
{
    public int[,]? Matrix { get; set; }
    public List<Edge> Edges = new();
    public List<Vertex> Vertexs=new();

    public void AddVertex(int number)
    {
        Vertexs.Add(new Vertex
        {
            Number = number
        });
    }

    public void AddEdge(Vertex v1, Vertex v2, int weight)
    {
        Edges.Add(new Edge(weight,v1,v2));
    }

    public void WriteVertex()
    {
        Console.Write("Вершины в графе: ");
        foreach (var vertex in Vertexs)
        {
            
            Console.Write(vertex.Number+" ");
        }
    }
}