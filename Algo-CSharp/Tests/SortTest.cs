using FluentAssertions;
using Xunit;

namespace Algo_CSharp.Tests
{
    public abstract class SortTest
    {
        [Fact]
        public void Test_2_8_7_1_3_5_6_4() => AssertSort(new[] { 2, 8, 7, 1, 3, 5, 4, 6 });

        [Fact]
        public void Test_Empty() => AssertSort(new int[0]);

        [Fact]
        public void Test_12345() => AssertSort(new[] { 1, 2, 3, 4, 5 });

        [Fact]
        public void Test_54321() => AssertSort(new[] { 5, 4, 3, 2, 1 });

        private void AssertSort(int[] input)
        {
            Sort(ref input);
            input.Should().BeInAscendingOrder();
        }

        protected abstract void Sort(ref int[] input);
    }
}