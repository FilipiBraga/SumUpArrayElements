using System.Diagnostics.CodeAnalysis;

namespace SumUpArrayElements;

[ExcludeFromCodeCoverage]
public static class Program
{
    private static readonly int[] sourceArray = new int[] { 3, 9, 4, 23, 7, 15, 14, 2, 59, 4 };
    private static int _outPutResult = 0;

    public static int GetOutPutResult() => _outPutResult;

    public static void Main()
    {
        Console.WriteLine("-------------------- Sum Up an Array of Integers");
        Console.WriteLine("------------------------------------------------");

        Console.WriteLine();

        Console.WriteLine(" ---------- Using For Loop");
        Console.WriteLine($" Result: {SumArrayElements.ForLoop(sourceArray)}");

        Console.WriteLine();

        Console.WriteLine(" ---------- Using Foreach Loop");
        Console.WriteLine($" Result: {SumArrayElements.ForeachLoop(sourceArray)}");

        Console.WriteLine();

        Console.WriteLine(" ---------- Using Array.ForEach");
        Console.WriteLine($" Result: {SumArrayElements.ArrayForEach(sourceArray)}");

        Console.WriteLine();

        Console.WriteLine(" ---------- Using Enumerable.Sum");
        Console.WriteLine($" Result: {SumArrayElements.EnumerableSum(sourceArray)}");

        Console.WriteLine();

        Console.WriteLine(" ---------- Using array.sum");
        Console.WriteLine($" Result: {SumArrayElements.ArraySum(sourceArray)}");

        Console.WriteLine();

        Console.WriteLine(" ---------- Using Enumerable.Aggregate");
        Console.WriteLine($" Result: {SumArrayElements.Aggregate(sourceArray)}");

        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");

        _outPutResult = 1;
    }
}