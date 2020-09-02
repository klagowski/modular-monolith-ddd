using BoardGames.BuildingBlocks.Domain.DomainEvents;
using BoardGames.BuildingBlocks.Domain.Events;
using System.Collections.Generic;

namespace BoardGames.BuildingBlocks.Domain.DomainDrivenDesign
{
    public abstract class AggregateRoot
    {
        private readonly IDomainEventsBus events;

        protected AggregateRoot(IDomainEventsBus events)
        {
            this.events = events;
        }

        protected void AddEvent(IDomainEvent @event)
            => events.AddEvent(@event);

        protected IEnumerable<IDomainEvent> GetAllEvents
            => events.GetAllEvents();
    }
}
