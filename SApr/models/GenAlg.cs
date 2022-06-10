using System.Diagnostics;

namespace SApr.models;

public class GenAlg
{
    public int CountPopulation { get; set; }
    public int Iteration{ get; set; }
    public double ChanseCrosover{ get; set; }
    public double ChanseMutation{ get; set; }
    public double ChanseInversion{ get; set; }
    public Graph _graph{ get; set; }
    public Genome BestGen = new();
    public Population _population;

    public GenAlg(int countPopulation, int iteration, double chanseCrosover, double chanseMutation, double chanseInversion, Graph graph)
    {
        CountPopulation = countPopulation;
        Iteration = iteration;
        ChanseCrosover = chanseCrosover;
        ChanseMutation = chanseMutation;
        ChanseInversion = chanseInversion;
        _graph = graph;
    }

    public void Go()
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();
        Random ran = new();
        _population = new Population(_graph);
        _population.CreateStartedPopulation(CountPopulation);
        double BestSumFitnes = 0;
        var x = 0;
        //Console.WriteLine(5);
        for (int i = 0; i < Iteration; i++)
        {
            var y = ran.NextDouble();
            if (y<=ChanseCrosover)
            {
                Crossingover();
            }
            y=ran.NextDouble();
            if (y<=ChanseMutation)
            {
                Mutations();
            }
            y=ran.NextDouble();
            if (y<=ChanseInversion)
            {
                Inversions();
            }
            _population.CalculateAverFitness();
            GetBestGen();
            //Console.WriteLine(5);
            if (_population.SumFitness>BestSumFitnes)
            {
                BestSumFitnes = _population.SumFitness;
                x = 0;
            }
            else
            {
                x += 1;
            }

            if (x==CountPopulation/20)
            {
                break;
            }
            //Console.WriteLine(5);
        }
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);

    }

    public void GetBestGen()
    {
        var b = _population.population.OrderBy(x => x.Fitness).Last();
        if (b.Fitness>BestGen.Fitness)
        {
            //Console.WriteLine(5);
            BestGen.Fitness = b.Fitness;
            BestGen.Gen = b.Gen.GetRange(0,b.Gen.Count);
        }
    }
    public void Inversions()
    {
        for (int i = 0; i < _population.population.Count; i++)
        {
            _population.Inversion(i);
        }
        
    }

    public void Mutations()
    {
        for (int i = 0; i < _population.population.Count; i++)
        {
            _population.Mutation(i);
        }
    }

    public void Crossingover()
    {
        _population.CreateNewParents();
        //Console.WriteLine(5);
        for (int j = 0; j < _population.population.Count-1; j+=2)
        {
            _population.Crossover(j,j+1);
        }

        if (_population.population.Count%2==1)
        {
             _population.population[_population.population.Count-1].Gen = _population.Parents[_population.population.Count-1].Gen.GetRange(0,_population.population[_population.population.Count-1].Gen.Count);
             _population.population[_population.population.Count-1].DetermineFitnes(_graph);
        }
        

    }
}