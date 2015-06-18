using System;

namespace DDDProject.Infra.DomainEvents.Interfaces
{
    public interface IDomainEvent
    {
        DateTime DateOccurred { get; }
    }
}
