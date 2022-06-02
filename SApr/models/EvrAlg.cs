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

        while (true)
        {
            var indSet = new IndSetVert();

            for (int i = 0; i < VertSort.Count; i++)
            {
                var x = VertSort[i].AdjVert.Intersect(indSet.SetVert).ToList();
                foreach (var VARIABLE in x)
                {
                    Console.WriteLine(VARIABLE.Number);
                }
                indSet.SetVert.Add(VertSort[i]);
                VertSort.Remove(VertSort[i]);
                t.Add(x);
            }

        }
    }
}