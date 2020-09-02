using System.Threading;
using System.Threading.Tasks;

namespace BoardGames.BuildingBlocks.Application.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync(CancellationToken cancellationToken = default);
    }
}
