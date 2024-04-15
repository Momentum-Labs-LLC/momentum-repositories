using Momentum.Repositories.Interfaces;

namespace Momentum.Repositories
{
    public record SearchResponse<T, TPage> : ISearchResponse<T, TPage>
    {
        public TPage NextPage { get; protected set; }
        public bool HasMore { get; protected set; }

        public IEnumerable<T>? Items { get; protected set; }

        public SearchResponse(IEnumerable<T>? items) : this(items, default, false) {} // end method

        public SearchResponse(IEnumerable<T>? items, TPage nextPage, bool hasMore)
        {
            Items = items;
            NextPage = nextPage;
            HasMore = hasMore;
        } // end method
    } // end record

    public record SearchResponse<T> : SearchResponse<T, int?>, ISearchResponse<T>
    {
        public SearchResponse(IEnumerable<T>? items) : base(items) { } // end method
        public SearchResponse(IEnumerable<T>? items, int? nextPage) 
            : base(items, nextPage, (nextPage.HasValue && nextPage.Value > 1)) 
        {
        } // end method
    } // end record
} // end namespace