using System;

namespace AntColony
{
  class AntColonyProgram
  {
    static Random random = new Random(0);
    static int alpha = 3;
    static int beta = 2;
    static double rho = 0.01;
    static double Q = 2.0;

    static void Main(string[] args)
    {
      try
      {
        Console.WriteLine("\nBegin Ant Colony Optimization demo\n");
        int numCities = 60;
        int numAnts = 4;
        int maxTime = 1000;

        int[][] dists = MakeGraphDistances(numCities);
        int[][] ants = InitAnts(numAnts, numCities); 

        int[] bestTrail = BestTrail(ants, dists);
        double bestLength = Length(bestTrail, dists);

        double[][] pheromones = InitPheromones(numCities);

        int time = 0;
        while (time < maxTime)
        {
          UpdateAnts(ants, pheromones, dists);
          UpdatePheromones(pheromones, ants, dists);
           
          int[] currBestTrail = BestTrail(ants, dists);
          double currBestLength = Length(currBestTrail, dists);
          if (currBestLength < bestLength)
          {
            bestLength = currBestLength;
            bestTrail = currBestTrail;
          }
          ++time;
        }

        Console.WriteLine("\nBest trail found:");
        Display(bestTrail);
        Console.WriteLine("\nLength of best trail found: " +
          bestLength.ToString("F1"));

        Console.WriteLine("\nEnd Ant Colony Optimization demo\n");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    } // Main

    static int[][] InitAnts(int numAnts, int numCities) { . . }
    
    static int[] RandomTrail(int start, int numCities) { . . }
    
    static int IndexOfTarget(int[] trail, int target) { . . }
    
    static double Length(int[] trail, int[][] dists) { . . }
    
    static int[] BestTrail(int[][] ants, int[][] dists) { . . }
    
    static double[][] InitPheromones(int numCities) { . . }
    
    static void UpdateAnts(int[][] ants, double[][] pheromones,
      int[][] dists) { . . }
    
    static int[] BuildTrail(int k, int start, double[][] pheromones,
      int[][] dists) { . . }
 
    static int NextCity(int k, int cityX, bool[] visited, double[][] pheromones,
      int[][] dists) { . . }

    static double[] MoveProbs(int k, int cityX, bool[] visited,
      double[][] pheromones, int[][] dists) { . . }
    
    static void UpdatePheromones(double[][] pheromones, int[][] ants,
      int[][] dists) { . . }
    
    static bool EdgeInTrail(int nodeX, int nodeY, int[] trail) { . . }
    
    static int[][] MakeGraphDistances(int numCities) { . . }
    
    static double Distance(int cityX, int cityY, int[][] dists) { . . }
    
    static void Display(int[] trail) { . . }
    
    static void ShowAnts(int[][] ants, int[][] dists) { . . }
    
    static void Display(double[][] pheromones) { . . }
  }
}