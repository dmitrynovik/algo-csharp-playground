using System;
using System.Collections.Generic;

namespace Algo_CSharp
{
    public class UndirectedGraph<T>
    {
        public class Node
        {
            public Node(T value)
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                Value = value;
            }

            public T Value { get; }
            public int Score { get; set; }
            public bool Visited { get; set; }
            public Node Parent { get; set; }

            public ICollection<Node> Edges { get; set; } = new HashSet<Node>();

            public override bool Equals(object obj)
            {
                if (obj is Node other)
                {
                    return other.Value.Equals(Value);
                }
                return false;
            }

            public override int GetHashCode() => Value.GetHashCode();
        }

        private HashSet<Node> _nodes = new HashSet<Node>();

        public IEnumerable<Node> Nodes  => _nodes;

        public void AddNode(Node node) => _nodes.Add(node);

        public void AddEdge(Node n1, Node n2)
        {
            if (!_nodes.Contains(n1))
                _nodes.Add(n1);

            if (!_nodes.Contains(n2))
                _nodes.Add(n2);

            n1.Edges.Add(n2);
            n2.Edges.Add(n1);
        }

        public bool Contains(Node node) => _nodes.Contains(node);
    }
}
