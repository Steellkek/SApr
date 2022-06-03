namespace SApr.models;

public class FormFamOfSets
{
    public List<List<Vertex>> FamOfSets = new();
    private List<Vertex> IndSetVert { get; set; }

    public void GetSet(Graph graph)
    {
        List<Vertex> VertSort = graph.Vertexs
            .OrderBy(x => x.Degre)
            .ToList();
        var flag = true;
        while (flag)
        {
            IndSetVert = new List<Vertex>();
            for (int i = VertSort.Count-1; i >= 0; i--)
            {
                var x = VertSort[i].AdjVert.Intersect(IndSetVert).ToList();
                if (x.Count==0)
                {
                    IndSetVert.Add(VertSort[i]);
                    VertSort.Remove(VertSort[i]);
                }
            }
            FamOfSets.Add(IndSetVert);
            if (VertSort.Count==0)
            {
                flag = false;
            }
        }
    }
}