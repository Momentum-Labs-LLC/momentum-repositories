using Momentum.Repositories.Interfaces;

namespace Momentum.Repositories
{
    public record SearchRequest<TPage> : ISearchRequest<TPage>
    {
        public TPage Page { get; protected set; }
        public int Size { get; protected set; }

        public SearchRequest(TPage page, int size) 
        { 
            Page = page; 
            Size = size; 
        } // end method
    } // end record

    public record SearchRequest : SearchRequest<int>, ISearchRequest
    {
        public SearchRequest(int page, int size) : base(page, size)
        {
        } // end methods
    } // end record
} // end namespace