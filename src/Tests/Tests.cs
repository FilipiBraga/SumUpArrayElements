using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumUpArrayElements;
using System;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        private readonly SumArrayElements _sumArrayElements = new();
        private readonly int[] sourceArray = new int[] { 3, 4, 8, 1, 6, 2 };

        [TestMethod]
        public void GivenTheMainProgram_ThenExecuteIt_ThenSetTheOutputResultToOne()
        {
            Program.Main(Array.Empty<string>());

            Assert.AreEqual(1, Program.OutPutResult);
        }

        [TestMethod]
        public void GivenASourceArray_ThenSumUpTheArrayValuesUsingForLoop_ThenReturnTheResult()
        {
            var result = _sumArrayElements.ForLoop(sourceArray);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void GivenASouceArray_ThenSumUpTheArrayValuesUsingForeachLoop_ThenReturnTheResult()
        {
            var result = _sumArrayElements.ForeachLoop(sourceArray);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void GivenASouceArray_ThenSumUpTheArrayValuesUsingArrayForEach_ThenReturnTheResult()
        {
            var result = _sumArrayElements.ArrayForEach(sourceArray);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void GivenASourceArray_ThenSumUpTheArrayValuesUsingEnumerableSum_ThenReturnTheResult()
        {
            var result = _sumArrayElements.EnumerableSum(sourceArray);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void GivenASourceArray_ThenSumUpTheArrayValuesUsingArraySum_ThenReturnTheResult()
        {
            var result = _sumArrayElements.ArraySum(sourceArray);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void GivenASourceArray_ThenSumUpTheArrayValuesUsingAggregate_ThenReturnTheResult()
        {
            var result = _sumArrayElements.Aggregate(sourceArray);

            Assert.AreEqual(24, result);
        }
    }
}