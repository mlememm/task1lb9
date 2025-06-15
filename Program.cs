using System;
delegate double MathFunction(double x);
class SimpleIterationSolver
{
    public static double Solve(MathFunction f, double initialGuess, double tolerance, int maxIterations)
    {
        double x0 = initialGuess;
        double x1 = f(x0);
        int iteration = 0;
        while (Math.Abs(x1 - x0) > tolerance && iteration < maxIterations)
        {
            x0 = x1;
            x1 = f(x0);
            iteration++;
        }
        return x1;
    }
}
class Example7
{
    public static void Run()
    {
        MathFunction f = x => Math.Cos(x);
        double root = SimpleIterationSolver.Solve(f, 0.5, 0.0001, 100);
        Console.WriteLine("Найдений корiнь: " + root);
    }
}
class Program
{
    static void Main()
    {
        Example7.Run();
    }
}