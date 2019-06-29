using  Xunit;
using  FluentAssertions;

namespace Algo_CSharp.Tests
{
    public class BinaryHeapTest
    {
        [Fact(Skip = "Order may be different")]        
        public void BuildHeapTest()
        {
            var items = new[] {4, 1, 3, 2, 16, 9, 10, 14, 8, 7};
            var heap = new HeapSort.BinaryHeap(items);
            heap.Items.Should().Equal(16, 14, 10, 8, 7, 9, 3, 2, 4, 1);
        }
    }
}
