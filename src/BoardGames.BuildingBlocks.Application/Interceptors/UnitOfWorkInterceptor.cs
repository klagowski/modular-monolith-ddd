using BoardGames.BuildingBlocks.Application.UnitOfWork;
using Castle.DynamicProxy;

namespace BoardGames.BuildingBlocks.Application.Interceptors
{
    public class UnitOfWorkInterceptor : IInterceptor
    {
        private readonly IUnitOfWork unitOfWork;

        public UnitOfWorkInterceptor(
            IUnitOfWork unitOfWork
            )
        {
            this.unitOfWork = unitOfWork;
        }

        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();

            unitOfWork.CommitAsync();
        }
    }
}
