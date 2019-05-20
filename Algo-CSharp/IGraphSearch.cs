namespace Algo_CSharp
{
    public interface IGraphSearch<T>
    {
        void Execute(UndirectedGraph<T>.Node startNode);
    }
}