using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_CSharp
{
    public class LinkedList<T>
    {
        private class Node<T>
        {
            private readonly T _value;

            public Node(T value) {  _value = value; }

            public LinkedList<T>.Node<T> Prev { get; set; }
            public LinkedList<T>.Node<T> Next { get; set; }

            public T Value => _value;
        }

        private LinkedList<T>.Node<T> _head;

        public void Insert(T val)
        {
            var node = new Node<T>(val);
            if (_head != null)
            {
                _head.Prev = node;
                node.Next = _head;
            }
            _head = node;
        }

        public void Remove(T val)
        {
            var p = _head;
            while (p != null)
            {
                if (p.Value.Equals(val))
                    Remove(p);

                p = p.Next;
            }
        }

        public bool Contains(T val)
        {
            var p = _head;
            while (p != null)
            {
                if (p.Value.Equals(val))
                    return true;

                p = p.Next;
            }

            return false;
        }

        public IEnumerable<T> Items
        {
            get
            {
                var p = _head;
                while (p != null)
                {
                    yield return p.Value;
                    p = p.Next;
                }
            }
        }

        public LinkedList<T> Reverse()
        {
            var r = new LinkedList<T>();
            foreach (var i in Items)
            {
                r.Insert(i);
            }
            return r;
        }

        private void Remove(Node<T> node)
        {
            if (node.Prev != null)
                node.Prev.Next = node.Next;
            else
                _head = node.Next;

            if (node.Next != null)
                node.Next.Prev = node.Prev;
        }
    }
}
