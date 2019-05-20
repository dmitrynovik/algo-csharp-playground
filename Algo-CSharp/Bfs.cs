using System;
using System.Collections.Generic;

namespace Algo_CSharp
{
    public class Bfs<T> : IGraphSearch<T>
    {
        private readonly UndirectedGraph<T> _graph;

        public Bfs(UndirectedGraph<T> graph)
        {
            _graph = graph;
        }

        public void Execute(UndirectedGraph<T>.Node startNode)
        {
            if (!_graph.Contains(startNode))
                throw new Exception("Node not found");

            startNode.Score = 0;
            var queue = new Queue<UndirectedGraph<T>.Node>();
            queue.Enqueue(startNode);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                current.Visited = true;
                current.Score = current.Parent?.Score + 1 ?? 0;

                foreach (var child in current.Edges)
                {
                    if (!child.Visited)
                    {
                        child.Parent = current;
                        queue.Enqueue(child);
                    }
                }
            }
        }
    }
}