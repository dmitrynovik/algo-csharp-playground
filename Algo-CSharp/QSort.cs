namespace Algo_CSharp
{
    public static class QSort
    {
        public static void Sort(ref int[] a, int lo, int hi)
        {
            if (a != null && lo < hi)
            {
                int q = Partition(ref a, lo, hi);
                Sort(ref a, lo, q - 1);
                Sort(ref a, q + 1, hi);
            }
        }

        private static int Partition(ref int[] a, int lo, int hi)
        {
            int pivot = a[hi];
            int i = 0;
            while (a[i] < pivot)
            {
                i++;
            }

            if (i < hi - 1)
            {
                for (int j = i + 1; j < hi; ++j)
                {
                    if (a[j] < pivot)
                    {
                        // Swap
                        Swap(ref a, i, j);
                        i++;
                    }
                }
            }

            Swap(ref a, hi, i);
            return i;
        }

        private static void Swap(ref int[] a, int i, int j)
        {
            int tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }

        public static void Sort(ref int[] input)
        {
            if (input != null)
                Sort(ref input, 0, input.Length - 1);
        }
    }
}
