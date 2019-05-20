using System;
using System.Linq;

namespace Algo_CSharp
{
    public class Dfs<T> : IGraphSearch<T>
    {
        private readonly UndirectedGraph<T> _graph;

        public Dfs(UndirectedGraph<T> graph)
        {
            _graph = graph;
        }

        public void Execute(UndirectedGraph<T>.Node startNode)
        {
            if (!_graph.Contains(startNode))
                throw new Exception("Node not found");

            Execute(startNode, 0);
        }

        public void Execute(UndirectedGraph<T>.Node startNode, int level)
        {
            startNode.Visited = true;
            startNode.Score = level;

            foreach (var child in startNode.Edges.Where(c => !c.Visited))
            {
                Execute(child, level + 1);
            }
        }
    }
}