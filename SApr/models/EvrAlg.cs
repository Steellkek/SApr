using System.Linq;

namespace SApr.models;

public class EvrAlg
{
    private List<int> Split { get; }
    public EvrAlg()
    {
        Split = new LocalFile().ReadSplit();
    }

    public Void GetStartSplit(FormFamOfSets sets)
    {
        foreach (var VARIABLE in sets.FamOfSets)
        {
            
        }
    }
}