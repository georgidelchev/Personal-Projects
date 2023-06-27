using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using StructureMap;

namespace EPiServerDemo.Business.DependencyResolvers
{
    public class StructureMapDependencyResolver : IDependencyResolver
    {
        private readonly IContainer container;

        public StructureMapDependencyResolver(
            IContainer container)
        {
            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType.IsInterface || serviceType.IsAbstract)
                return GetInterfaceService(serviceType);

            return GetConcreteService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
            => this.container.GetAllInstances(serviceType).Cast<object>();

        private object GetConcreteService(Type serviceType)
            => this.container.GetInstance(serviceType);

        private object GetInterfaceService(Type serviceType)
            => this.container.TryGetInstance(serviceType);
    }
}