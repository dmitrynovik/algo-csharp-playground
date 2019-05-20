using System.IO;
using System.Text;
using FluentAssertions;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class BinaryTreeTest
    {
        [Fact]
        public void Foo()
        {
            var tree = new BinaryTree<int>(2);
            tree.Add(1);
            tree.Add(4);

            var output = Print(tree);
            output.Should().Be("1,2,4,");
        }

        private static string Print(BinaryTree<int> tree)
        {
            var builder = new StringBuilder();
            using (var writer = new StringWriter(builder))
            {
                tree.PrintInOrder(writer);
            }
            return builder.ToString();
        }
    }
}
