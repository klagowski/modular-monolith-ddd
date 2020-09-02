using MediatR;

namespace BoardGames.BuildingBlocks.Domain.Requests
{
    //Marker
    public interface IQuery<out TResult> : IRequest<TResult>
    {
    }
}
