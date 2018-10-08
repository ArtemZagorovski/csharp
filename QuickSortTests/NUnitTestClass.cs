using NUnit.Framework;
using System;
namespace SortingTests
{
    [TestFixture()]
    public class NUnitTestClass
    {
        [Test()
             public class Tests
        {
            [Test]
            public void Quicksort_RegularIntArrayPassed_ArrayIsSorted()
            {
                int[] source = new[] { 3, 1, 5, 4, 9, 6, 2, 7, 8 };

                int p = 0;

                int r = source.Length - 1;

                int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                Sorting.Quicksort(source, p, r);

                Assert.AreEqual(expected, source);
            }
        }
    }
}
