using Momentum.Repositories.Interfaces;

namespace Momentum.Repositories
{
    public record SearchResponse<T, TPage> : ISearchResponse<T, TPage>
    {
        public TPage? NextPage { get; protected set; }

        public IEnumerable<T>? Items { get; protected set; }

        public SearchResponse(IEnumerable<T>? items, TPage? nextPage)
        {
            Items = items;
            NextPage = nextPage;
        } // end method
    } // end record

    public record SearchResponse<T> : SearchResponse<T, int>, ISearchResponse<T>
    {
        public SearchResponse(IEnumerable<T>? items) : base(items, 0) {} // end method
        public SearchResponse(IEnumerable<T>? items, int nextPage) : base(items, nextPage)
        {
        } // end method
    } // end record
} // end namespace