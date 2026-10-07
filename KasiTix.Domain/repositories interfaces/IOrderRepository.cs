using KasiTix.Domain.Entities;

namespace KasiTix.Domain.Repositories;

public interface IOrderRepository
{
    void Add(Order order);
    Task<Order?> GetByIdempotencyKeyAsync(string key, CancellationToken ct);                 // AsNoTracking
    Task<bool> HasConfirmedOrderAsync(Guid eventId, string buyerEmail, CancellationToken ct);
    Task<List<Order>> GetConfirmedForUpdateAsync(Guid eventId, CancellationToken ct);        // tracked, for cancel (R11)
    Task<(List<Order> Items, bool HasMore)> PageAsync(                                       // Tier 2, endpoint 7
        Guid eventId, DateTimeOffset? afterCreatedAt, Guid? afterId, int pageSize, CancellationToken ct);
}