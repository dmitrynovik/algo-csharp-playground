using FluentAssertions;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class BinaryTreeTest
    {
        [Fact]
        public void InOrder_Print_1_2_4()
        {
            var tree = new BinaryTree<int>(2);
            tree.Add(1);
            tree.Add(4);
            Print(tree).Should().Be("1,2,4");
        }

        [Fact]
        public void InOrder_Print_1_2_3_4_5()
        {
            var tree = new BinaryTree<int>(5);
            tree.Add(4);
            tree.Add(3);
            tree.Add(2);
            tree.Add(1);
            Print(tree).Should().Be("1,2,3,4,5");
        }

        private static string Print(BinaryTree<int> tree, string delimiter = ",") => string.Join(delimiter, tree.InOrder());
    }
}
