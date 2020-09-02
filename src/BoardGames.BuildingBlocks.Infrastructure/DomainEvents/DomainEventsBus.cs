using BoardGames.BuildingBlocks.Domain.DomainEvents;
using BoardGames.BuildingBlocks.Domain.Events;
using System.Collections.Generic;

namespace BoardGames.BuildingBlocks.Infrastructure.DomainEvents
{
    public class DomainEventsBus : IDomainEventsBus
    {
        private readonly ISet<IDomainEvent> events = new HashSet<IDomainEvent>();

        public DomainEventsBus()
        {
        }

        public void AddEvent(IDomainEvent @event)
        {
            events.Add(@event);
        }

        public IEnumerable<IDomainEvent> GetAllEvents()
        {
            return events;
        }

        public void ClearAllEvents()
        {
            events.Clear();
        }
    }
}
