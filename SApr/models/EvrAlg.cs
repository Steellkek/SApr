using System.Linq;

namespace SApr.models;

public class EvrAlg
{
    public List<IndSetVert> FamOfSets = new();

    public void GetSet(Graph graph)
    {
        List<Vertex> VertSort = graph.Vertexs
            .OrderBy(x => x.Degre)
            .ToList();
        List<IEnumerable<Vertex>> t = new List<IEnumerable<Vertex>>();
        var l = true;
        while (l)
        {
            var indSet = new IndSetVert();
            for (int i = VertSort.Count-1; i >= 0; i--)
            {
                var x = VertSort[i].AdjVert.Intersect(indSet.SetVert).ToList();
                if (x.Count==0)
                {
                    indSet.SetVert.Add(VertSort[i]);
                    VertSort.Remove(VertSort[i]);
                    Console.WriteLine(0);
                }
            }
            FamOfSets.Add(indSet);
            if (VertSort.Count==0)
            {
                l = false;
            }
        }
    }
}