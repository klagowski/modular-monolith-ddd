using BoardGames.BuildingBlocks.Application.DomainEvents;
using Castle.DynamicProxy;

namespace BoardGames.BuildingBlocks.Application.Interceptors
{
    public class DispatchDomainEventsInterceptor : IInterceptor
    {
        private readonly IDomainEventsDispatcher domainEventsDispatcher;

        public DispatchDomainEventsInterceptor(
            IDomainEventsDispatcher domainEventsDispatcher
            )
        {
            this.domainEventsDispatcher = domainEventsDispatcher;
        }

        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();

            domainEventsDispatcher.DispatchEventsAsync();
        }
    }
}
