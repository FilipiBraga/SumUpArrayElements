namespace SumUpArrayElements
{
    public class SumArrayElements
    {
        public int ForStatement(int[] sourceArray)
        {
            var result = 0;
            for (int i = 0; i < sourceArray.Length; i++)
            {
                result += sourceArray[i];
            }

            return result;
        }

        public int ForeachStatement(int[] sourceArray)
        {
            var result = 0;
            foreach (var item in sourceArray)
            {
                result += item;
            }

            return result;
        }

        public int EnumerableSum(int[] sourceArray)
        {
            return Enumerable.Sum(sourceArray);
        }

        public int ArraySum(int[] sourceArray)
        {
            return sourceArray.Sum();
        }

        public int Aggregate(int[] sourceArray)
        {
            return sourceArray.Aggregate((total, value) => total + value);
        }
    }
}
