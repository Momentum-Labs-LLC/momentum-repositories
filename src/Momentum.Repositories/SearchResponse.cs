using Momentum.Repositories.Interfaces;

namespace Momentum.Repositories
{
    public record SearchResponse<T, TPage> : ISearchResponse<T, TPage>
    {
        public TPage? NextPage { get; protected set; }

        public IEnumerable<T>? Items { get; protected set; }

        public SearchResponse(IEnumerable<T>? items, TPage? page)
        {
            Items = items;
            NextPage = page;
        } // end method
    } // end record

    public record SearchResponse<T> : SearchResponse<T, int>, ISearchResponse<T>
    {
        public SearchResponse(IEnumerable<T>? items, int page) : base(items, page)
        {
        } // end method
    } // end record
} // end namespace