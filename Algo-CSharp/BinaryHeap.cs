using System.Collections.Generic;

namespace Algo_CSharp
{
    public static class HeapSort
    {
        public static void Sort(ref int[] a)
        {
            var heap = new BinaryHeap(a);
            for (int i = a.Length - 1; i >= 1; --i)
            {
                // Swap:
                var tmp = heap._items[0];
                heap._items[0] = heap._items[i];
                heap._items[i] = tmp;

                heap.Size = heap.Size - 1;
                heap.Heapify(0);
            }

            a = heap._items;
            //.Reverse()
            //.ToArray();
        }

        public class BinaryHeap
        {
            internal int[] _items;

            public int Length { get; private set; }
            public int Size { get; set; }

            public IEnumerable<int> Items => _items;

            public int? Left(int pos) => pos * 2 < _items.Length ? (int?)_items[pos * 2] : null;
            public int? Right(int pos) => pos * 2 + 1 < _items.Length ? (int?)_items[pos * 2 + 1] : null;

            public BinaryHeap(int[] items)
            {
                _items = items ?? new int[0];
                Size = _items.Length;
                Length = _items.Length;

                if (_items.Length == 0)
                    return;

                for (int i = _items.Length / 2; i >= 0; --i)
                {
                    Heapify(i);
                }
            }

            internal void Heapify(int i)
            {
                var largest = _items[i];
                int j = i;
                var left = Left(i);
                var right = Right(i);

                if (left > largest)
                {
                    largest = left.Value;
                    j = i * 2;
                }

                if (right > largest)
                {
                    largest = right.Value;
                    j = (i * 2) + 1;
                }

                if (i != j)
                {
                    // Swap
                    var tmp = _items[i];
                    _items[i] = largest;
                    _items[j] = tmp;
                    Heapify(j);
                }
            }
        }
    }

}
