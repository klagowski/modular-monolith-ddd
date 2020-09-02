using System.Threading.Tasks;

namespace BoardGames.BuildingBlocks.Application.DomainEvents
{
    public interface IDomainEventsDispatcher
    {
        Task DispatchEventsAsync();
    }
}