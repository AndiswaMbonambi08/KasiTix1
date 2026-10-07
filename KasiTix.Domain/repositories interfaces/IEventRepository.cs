using KasiTix.Domain.Entities;

namespace KasiTix.Domain.Repositories;

public interface IEventRepository
{
    void Add(Event ev);
    Task<Event?> GetForUpdateAsync(Guid id, CancellationToken ct);   // tracked, with TicketTypes
    Task<Event?> GetDetailAsync(Guid id, CancellationToken ct);      // AsNoTracking, with TicketTypes
    Task<bool> ExistsAsync(Guid id, CancellationToken ct);
    Task<List<Event>> ListByStatusAsync(EventStatus status, CancellationToken ct);   // Tier 2, endpoint 6
}