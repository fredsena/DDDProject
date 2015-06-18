using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Infra.DomainEvents.Interfaces
{
    public interface IHandles<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}
