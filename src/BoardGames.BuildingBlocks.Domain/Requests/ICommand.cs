using MediatR;

namespace BoardGames.BuildingBlocks.Domain.Requests
{
    //Marker
    public interface ICommand<out TResult> : IRequest<TResult>
    {
    }

    public interface ICommand : IRequest<Unit>
    {
    }
}
