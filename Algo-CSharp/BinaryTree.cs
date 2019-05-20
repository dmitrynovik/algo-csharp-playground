using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algo_CSharp
{
    public class BinaryTree<T> where T: IComparable<T>
    {
        public enum Order { InOrder, PreOrder, PostOrder }

        public class Node
        {
            public Node(T value)
            {
                if (value == null) throw new ArgumentNullException(nameof(value));
                Value = value;
            }

            public T Value { get; }

            public Node Left { get; set; }
            public Node Right { get; set; }

            public void Add(T value)
            {
                var comparison = Value.CompareTo(value);

                if (comparison == 0)
                    return;

                if (comparison > 0)
                {
                    // add left
                    if (Left == null)
                        Left = new Node(value);
                    else
                        Left.Add(value);
                }
                else
                {
                    // add right:
                    if (Right == null)
                        Right = new Node(value);
                    else
                        Right.Add(value);
                }
            }

            public IEnumerable<T> PreOrder()
            {
                var items = Enumerate();
                return items.Item2.Concat(items.Item1).Concat(items.Item3);
            }

            public IEnumerable<T> PostOrder()
            {
                var items = Enumerate();
                return items.Item1.Concat(items.Item3).Concat(items.Item2);
            }

            public IEnumerable<T> InOrder()
            {
                var items = Enumerate();
                return items.Item1.Concat(items.Item2).Concat(items.Item3);
            }

            private (IEnumerable<T>, IEnumerable<T>, IEnumerable<T>) Enumerate()
            {
                var left = Left != null ? Left.InOrder() : Enumerable.Empty<T>();
                var right = Right != null ? Right.InOrder() : Enumerable.Empty<T>();
                var self = new[] {Value};
                return (left, self, right);
            }
        }

        public BinaryTree(T value) { Root = new Node(value) ; }

        public Node Root { get; set; }

        public void Add(T value) => Root.Add(value);

        public IEnumerable<T> InOrder() => Root.InOrder();
    }
}
