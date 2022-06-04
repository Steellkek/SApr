using System.Linq;

namespace SApr.models;

public class EvrAlg
{
    private List<int> Split { get; }
    public EvrAlg()
    {
        Split = new LocalFile().ReadSplit();
    }

    public void GetStartSplit(FormFamOfSets sets)
    {
        List<Vertex[]> x = new List<Vertex[]>();
        foreach (var split in Split)
        {
            Vertex[] y = new Vertex[split];
            x.Add(y);
        }

        for (int i = sets.FamOfSets[0].Count-1; i >=0 ; i--)
        {
            foreach (var VARIABLE in x)
            {
                
            }
        }
        foreach (var set in sets.FamOfSets)
        {
            
        }
    }
}