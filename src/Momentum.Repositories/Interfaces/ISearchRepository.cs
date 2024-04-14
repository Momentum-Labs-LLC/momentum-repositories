namespace Momentum.Repositories.Interfaces
{
    public interface ISearchRepository<T, TPage, TRequest, TResponse>
        where TRequest : ISearchRequest<TPage>
        where TResponse : ISearchResponse<TResponse, TPage>
    {
        Task<TResponse> SearchAsync(TRequest request, CancellationToken token = default);
    } // end interface
} // end interface