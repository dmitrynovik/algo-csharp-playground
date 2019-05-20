using System.Linq;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class DfsTest
    {
        [Fact]
        public void Execute()
        {
            var graph = new UndirectedGraph<int>();

            var node0 = new UndirectedGraph<int>.Node(0);
            var node1 = new UndirectedGraph<int>.Node(1);
            var node2 = new UndirectedGraph<int>.Node(2);
            var node3 = new UndirectedGraph<int>.Node(3);
            var node4 = new UndirectedGraph<int>.Node(4);

            graph.AddEdge(node0, node1);
            graph.AddEdge(node0, node2);
            graph.AddEdge(node1, node3);
            graph.AddEdge(node4, node2);

            var bfs = new Dfs<int>(graph);
            bfs.Execute(node0);

            using (new AssertionScope("assert DFS correctness"))
            {
                graph.Nodes.Select(n => n.Visited).Should().AllBeEquivalentTo(true);
                node0.Score.Should().Be(0);
            }
        }
    }
}