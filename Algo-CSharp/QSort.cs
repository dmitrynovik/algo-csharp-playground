namespace Algo_CSharp
{
    public static class QSort
    {
        public static void Sort(int[] a, int lo, int hi)
        {
            if (a != null && lo < hi)
            {
                int q = Partition(a, lo, hi);
                Sort(a, lo, q - 1);
                Sort(a, q + 1, hi);
            }
        }

        private static int Partition(int[] a, int lo, int hi)
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
                        Swap(a, i, j);
                        i++;
                    }
                }
            }

            Swap(a, hi, i);
            return i;
        }

        private static void Swap(int[] a, int i, int j)
        {
            int tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }

        public static void Sort(int[] input)
        {
            if (input != null)
                Sort(input, 0, input.Length - 1);
        }
    }
}
