using BoardGames.BuildingBlocks.Application.Attributes;
using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BoardGames.BuildingBlocks.Application.Interceptors
{
    class InterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var selectors = new List<Type> { };

            if (type.GetMethods().Any(y => y.Name == method.Name && y.GetCustomAttributes(typeof(UnitOfWorkCommitAttribute), true).Any()))
            {
                selectors.Add(typeof(UnitOfWorkInterceptor));
            }

            if (type.GetMethods().Any(y => y.Name == method.Name && y.GetCustomAttributes(typeof(DispatchDomainEventsAttribute), true).Any()))
            {
                selectors.Add(typeof(DispatchDomainEventsInterceptor));
            }

            return interceptors.Where(x => selectors.Contains(x.GetType())).ToArray();
        }
    }
}
