using BoardGames.BuildingBlocks.Domain.Requests;
using MediatR;

namespace BoardGames.BuildingBlocks.Application.Requests
{
    public interface IQueryHandler<in TRequest, TResult> : IRequestHandler<TRequest, TResult> where TRequest : IQuery<TResult>
    {
    }
}
