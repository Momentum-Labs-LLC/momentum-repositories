using Momentum.Repositories.Interfaces;

namespace Momentum.Repositories
{
    public record SearchRequest<TPage> : ISearchRequest<TPage>
    {
        public TPage? Page { get; protected set; }
        public int Size { get; protected set; }

        public SearchRequest(TPage? page, int size) 
        { 
            Page = page; 
            Size = size; 
        } // end method
    } // end record

    public record SearchRequest : SearchRequest<int>, ISearchRequest
    {
        private const int PAGE_DEFAULT = 1;
        public SearchRequest(int size) : base(PAGE_DEFAULT, size) {} // end method
        public SearchRequest(int page, int size) : base(page, size)
        {
            if(page < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(page), "Page is expected to be at least 1.");
            } // end method
        } // end methods
    } // end record
} // end namespace