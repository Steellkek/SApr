using System.Net.Mime;

namespace SApr.models;

public class LocalFile
{
    private string WayGraph="Граф.txt";
    private string WaySplit="разбиение.txt";

    public List<List<int>> ReadGraph()
    {
        List<List<int>> matrix;

        try
        {
            int L;
            using (StreamReader lf = new StreamReader(WayGraph))
            {
                L = Int32.Parse(lf.ReadLine());
                matrix = lf
                    .ReadToEnd()
                    .Split(Array.Empty<string>(), StringSplitOptions.RemoveEmptyEntries)
                    .Select((s, i) => new { N = int.Parse(s), I = i})
                    .GroupBy(at => at.I/L, at => at.N, (k, g) => g.ToList())
                    .ToList();;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("привет");
            throw;
        }
        
        return matrix;
    }

    public List<int> ReadSplit()
    {
        List<int> split;

        using (StreamReader lf = new StreamReader(WaySplit))
        {
            split = lf
                .ReadToEnd()
                .Split(Array.Empty<string>(), StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();
        }
        
        return split;
    }
}