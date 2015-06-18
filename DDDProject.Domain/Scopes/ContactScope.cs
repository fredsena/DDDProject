using DDDProject.Domain.Entities;
using DDDProject.Infra.DomainEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Domain.Scopes
{
    public static class ContactScope
    {
        public static bool IsValid(this Contact contact)
        {
            return
            AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(contact.ContactName, "name is required"),
                AssertionConcern.AssertNotEmpty(contact.CompanyName, "Company name is required")
            );
        }
    }
}
