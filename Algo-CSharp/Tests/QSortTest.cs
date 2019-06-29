namespace Algo_CSharp.Tests
{
    public class QSortTest : SortTest
    {
        protected override void Sort(ref int[] input) => QSort.Sort(ref input);
    }
}
