namespace Momentum.Repositories.Interfaces
{
    public interface IRepository<TId, T>
    {
        Task<T> CreateAsync(TId id, CancellationToken token = default);
        Task DeleteAsync(T item, CancellationToken token = default);
        Task<T?> GetAsync(TId id, CancellationToken token = default);
        Task<T> UpdateAsync(TId id, T item, CancellationToken token = default);
    } // end interface

    public interface IRepository<T> : IRepository<Guid, T> {} // end interface
    public interface ILookupRepository<T> : IRepository<int, T> {} // end interface
} // end namespace