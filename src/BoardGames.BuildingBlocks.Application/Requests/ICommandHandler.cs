using BoardGames.BuildingBlocks.Domain.Requests;
using MediatR;

namespace BoardGames.BuildingBlocks.Application.Requests
{
    public interface ICommandHandler<in TRequest, TResult> : IRequestHandler<TRequest, TResult> where TRequest : ICommand<TResult>
    {
    }

    public interface ICommandHandler<in TRequest> : IRequestHandler<TRequest, Unit> where TRequest : ICommand
    {
    }
}
