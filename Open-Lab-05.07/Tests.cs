using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;

namespace Open_Lab_05._07
{
    [TestFixture]
    public class Tests
    {

        private Numbers numbers;

        private const int RandSeed = 507507507;
        private const int RandNumsMinCount = 5;
        private const int RandNumsMaxCount = 25;
        private const int RandNumsMaxVal = 10000;
        private const int RandTestCasesCount = 97;

        [OneTimeSetUp]
        public void Init() => numbers = new Numbers();

        [TestCase(new []{ 1, 2, 3, 4, 5 }, new []{ 2, 3, 4, 5 })]
        [TestCase(new []{ 5, 3, 2, 1, 4 }, new []{ 5, 3, 2, 4 })]
        [TestCase(new []{ 2, 2, 1, 2, 1 }, new []{ 2, 2, 2, 1 })]
        [TestCaseSource(nameof(GetRandom))]
        public void RemoveSmallestTest(int[] arr, int[] expected) =>
            Assert.That(numbers.RemoveSmallest(arr), Is.EqualTo(expected));

        private static IEnumerable GetRandom()
        {
            var rand = new Random(RandSeed);

            for (var i = 0; i < RandTestCasesCount; i++)
            {
                var arr = new int[rand.Next(RandNumsMinCount, RandNumsMaxCount + 1)];

                for (var j = 0; j < arr.Length; j++)
                    arr[j] = rand.Next(RandNumsMaxVal);

                yield return new TestCaseData(arr, arr.Where((n, i) => i != Array.IndexOf(arr, arr.Min())).ToArray());
            }
        }

    }
}
