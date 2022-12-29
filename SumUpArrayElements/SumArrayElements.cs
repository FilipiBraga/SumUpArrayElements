namespace SumUpArrayElements
{
    public class SumArrayElements
    {
        public static int ForLoop(int[] sourceArray)
        {
            var result = 0;
            
            for (int i = 0; i < sourceArray.Length; i++)
                result += sourceArray[i];

            return result;
        }

        public static int ForeachLoop(int[] sourceArray)
        {
            var result = 0;
            
            foreach (var item in sourceArray)
                result += item;

            return result;
        }

        public static int ArrayForEach(int[] sourceArray)
        {
            var result = 0;
            
            Array.ForEach(sourceArray, value => result += value);

            return result;
        }

        public static int EnumerableSum(int[] sourceArray)
        {
            return Enumerable.Sum(sourceArray);
        }

        public static int ArraySum(int[] sourceArray)
        {
            return sourceArray.Sum();
        }
       
        public static int Aggregate(int[] sourceArray)
        {
            return sourceArray.Aggregate((total, value) => total + value);
        }
    }
}
