using BoardGames.BuildingBlocks.Application.DomainEvents;
using BoardGames.BuildingBlocks.Domain.DomainEvents;
using BoardGames.BuildingBlocks.Domain.Events;
using MediatR;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGames.BuildingBlocks.Infrastructure.DomainEvents
{
    public class DomainEventsDispatcher : IDomainEventsDispatcher
    {
        private readonly IMediator mediator;
        private readonly IDomainEventsBus domainEventsBus;

        public DomainEventsDispatcher(
            IMediator mediator,
            IDomainEventsBus domainEventsBus)
        {
            this.domainEventsBus = domainEventsBus;
            this.mediator = mediator;
        }

        public async Task DispatchEventsAsync()
        {
            var domainEvents = domainEventsBus.GetAllEvents();

            domainEventsBus.ClearAllEvents();

            var tasks = domainEvents.Select(async (domainEvent) =>
            {
                await mediator.Publish(domainEvent);
            });

            await Task.WhenAll(tasks);
        }
    }
}
