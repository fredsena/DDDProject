using DDDProject.Infra.DomainEvents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Domain.Entities.Events
{
    public class ContactEvent : IDomainEvent
    {
        public DateTime DateOccurred { get; private set; }
    }
}
