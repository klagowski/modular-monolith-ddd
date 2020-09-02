using BoardGames.BuildingBlocks.Integration.IntegrationEvents;
using MediatR;

namespace BoardGames.BuildingBlocks.Application.IntegrationEvents
{
    //Marker
    public interface IIntegrationEventHandler<in T> : INotificationHandler<T> where T : IIntegrationEvent
    {
    }
}
