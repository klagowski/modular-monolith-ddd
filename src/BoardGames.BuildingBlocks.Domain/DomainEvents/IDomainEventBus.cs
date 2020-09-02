using BoardGames.BuildingBlocks.Domain.Events;
using System.Collections.Generic;

namespace BoardGames.BuildingBlocks.Domain.DomainEvents
{
    public interface IDomainEventsBus
    {
        void AddEvent(IDomainEvent @event);

        IEnumerable<IDomainEvent> GetAllEvents();

        void ClearAllEvents();
    }
}
