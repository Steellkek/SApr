using System.Net.Mime;

namespace SApr.models;

public class LocalFile
{
    private string Way="Граф.txt";

    public List<List<int>> ReadGraph()
    {
        List<List<int>> matrix;
        int L;
        try
        {
            using (StreamReader lf = new StreamReader(Way))
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

    
}