using System;
using System.IO;

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

            public void PrintInOrder(TextWriter writer)
            {
                if (Left != null)
                    Left.PrintInOrder(writer);

                writer.Write(Value);
                writer.Write(',');

                Right?.PrintInOrder(writer);
            }
        }

        public BinaryTree(T value) { Root = new Node(value) ; }

        public Node Root { get; set; }

        public void Add(T value) => Root.Add(value);

        public void PrintInOrder(TextWriter writer) => Root.PrintInOrder(writer);
        public void PrintInOrder() => Root.PrintInOrder(Console.Out);
    }
}
