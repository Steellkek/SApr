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


        
        foreach (var set in sets.FamOfSets.OrderBy(set=>set.Count))
        {
            foreach (var v in set)
            {
                for (int i = 0; i < x.Count; i++)
                {

                    var flag = false;
                    if (x[i].Last() == null)
                    {
                        for (int j = 0; j < x[i].Length; j++)
                        {
                            x[i][Array.IndexOf(x[i], null)] = v;
                            set.Remove(v);
                            flag = true;
                            break;
                        }
                    }

                    if (flag)
                    {
                        break;
                    }
                }
            }
        }
        Console.WriteLine(x);
    }
}