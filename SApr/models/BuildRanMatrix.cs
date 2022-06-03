namespace SApr.models;

public class BuildRanMatrix
{
    Random ran = new Random();
    int[,] BuildMatrix(int N)
    {
        int[,] matrix = new int[N, N];
        for (int i = 0; i < N; i++)
        {
            matrix[i, i] = 0;
            for (int j = i + 1; j < N; j++)
            {
                matrix[i, j] = ran.Next(0, 20);
                matrix[j, i] = matrix[i, j]; // обратный порядок индексов
            }
        }
        return matrix;
    }

    public void WriteMatix()
    {
        using (StreamWriter stream = new StreamWriter("matrix.txt"))
        {
            int n = 200;
            var x = BuildMatrix(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    stream.Write(x[i,j]+" ");
                }
                stream.WriteLine();
            }  
        }

    }
}