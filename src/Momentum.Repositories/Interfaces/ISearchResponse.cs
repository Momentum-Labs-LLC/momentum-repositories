namespace Momentum.Repositories.Interfaces
{
    public interface ISearchResponse<T, TPage>
    {
        TPage NextPage { get; }
        IEnumerable<T>? Items { get; }
    } // end interface

    public interface ISearchResponse<T> : ISearchResponse<T, int?> {} // end interface
} // end namespace