using BenchmarkDotNet.Attributes;
using SumUpArrayElements;

namespace BenchmarkRunner
{
    public class SumArrayElementsBenchmark
    {
        private static readonly int[] _sourceArray = FillElements(1000 * 100);

        private static int[] FillElements(int length)
        {
            var randomArray = new int[length];

            for (int i = 0; i < length; i++)
                randomArray[i] = 100;

            return randomArray;
        }

        [Benchmark]
        public void UsingForLoop()
        {
            SumArrayElements.ForLoop(_sourceArray);
        }

        [Benchmark]
        public void UsingForeachLoop()
        {
            SumArrayElements.ForeachLoop(_sourceArray);
        }

        [Benchmark]
        public void UsingArrayForEach()
        {
            SumArrayElements.ArrayForEach(_sourceArray);
        }

        [Benchmark]
        public void UsingEnumerableSum()
        {
            SumArrayElements.EnumerableSum(_sourceArray);
        }

        [Benchmark]
        public void UsingArraySum()
        {
            SumArrayElements.ArraySum(_sourceArray);
        }

        [Benchmark]
        public void UsingAggregate()
        {
            SumArrayElements.Aggregate(_sourceArray);
        }
    }
}