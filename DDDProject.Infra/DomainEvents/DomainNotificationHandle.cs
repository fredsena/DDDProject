using DDDProject.Infra.DomainEvents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDDProject.Infra.DomainEvents
{
    public class DomainNotificationHandle : IDomainNotificationHandle<DomainNotification>
    {
        private List<DomainNotification> _notifications;

        public DomainNotificationHandle()
        {
            _notifications = new List<DomainNotification>();
        }

        public void Handle(DomainNotification args)
        {
            _notifications.Add(args);
        }

        public List<DomainNotification> Notify()
        {
            return GetValue();
        }

        private List<DomainNotification> GetValue()
        {
            return _notifications;
        }

        public bool HasNotifications()
        {
            return GetValue().Count > 0;
        }
    }
}
