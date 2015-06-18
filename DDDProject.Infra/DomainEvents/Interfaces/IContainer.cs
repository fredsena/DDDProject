using System;
using System.Collections.Generic;

namespace DDDProject.Infra.DomainEvents.Interfaces
{
    public interface IContainer
    {
        object GetService(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
    }
}
