using System.Diagnostics.CodeAnalysis;

namespace BenchmarkRunner;

[ExcludeFromCodeCoverage]
public static class Program
{
    public static void Main(string[] args)
    {
        BenchmarkDotNet.Running.BenchmarkRunner.Run<SumArrayElementsBenchmark>();
    }
}
