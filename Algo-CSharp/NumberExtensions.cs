namespace Algo_CSharp
{
    public static class NumberExtensions
    {
        public static bool IsPowerOfTwo(this int num) => num > 0 && (num & (num - 1)) == 0;
    }
}