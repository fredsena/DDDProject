
using System.Collections.Generic;

namespace DDDProject.Infra.DomainEvents.Interfaces
{
    public interface IDomainNotificationHandle<T> : IHandles<T> where T : IDomainEvent
    {
        List<T> Notify();
        bool HasNotifications();
    }
}
