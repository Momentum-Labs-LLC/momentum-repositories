namespace Momentum.Repositories.Interfaces
{
    public interface ISearchRequest<TPage>
    {
        TPage Page { get; }
        int Size { get; }
    } // end interface

    public interface ISearchRequest : ISearchRequest<int> {} // end interface
} // end namespace