using BoardGames.BuildingBlocks.Domain.Events;
using MediatR;

namespace BoardGames.BuildingBlocks.Application.DomainEvents
{
    //Marker
    public interface IDomainEventHandler<in T> : INotificationHandler<T> where T : IDomainEvent
    {
    }
}
