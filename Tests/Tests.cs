using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumUpArrayElements;
using System;
using System.Security.Cryptography;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        private readonly int[] sourceArray = new int[] { 3, 4, 8, 1, 6, 2 };

        [TestMethod]
        public void GivenTheMainProgram_WhenExecuteTheMainMethod_ThenSetTheOutputResultToOne()
        {
            Program.Main();

            Assert.AreEqual(1, Program.GetOutPutResult());
        }

        [TestMethod]
        public void GivenASourceArray_WhenUsingTheForLoopMethod_ThenReturnTheSumOfTheElements()
        {
            var result = SumArrayElements.ForLoop(sourceArray);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void GivenASouceArray_WhenUsingTheForeachLoopMethod_ThenReturnTheSumOfTheElements()
        {
            var result = SumArrayElements.ForeachLoop(sourceArray);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void GivenASouceArray_WhenUsingArrayForEachMethod_ThenReturnTheSumOfTheElements()
        {
            var result = SumArrayElements.ArrayForEach(sourceArray);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void GivenASourceArray_WhenUsingEnumerableSumMethod_ThenReturnTheSumOfTheElements()
        {
            var result = SumArrayElements.EnumerableSum(sourceArray);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void GivenASourceArray_WhenUsingTheArraySumMethod_ThenReturnTheSumOfTheElements()
        {
            var result = SumArrayElements.ArraySum(sourceArray);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void GivenASourceArray_WhenUsingAggregateMethod_ThenReturnTheSumOfTheElements()
        {
            var result = SumArrayElements.Aggregate(sourceArray);

            Assert.AreEqual(24, result);
        }
    }
}