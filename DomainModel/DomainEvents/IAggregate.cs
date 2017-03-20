using System;
using System.Collections.Generic;

namespace DomainModel.DomainEvents
{
    public interface IAggregate
    {
        Guid Id { get; }

        bool HasPendingChanges { get; }

        IEnumerable<DomainEvent> GetUncommittedEvents();

        void ClearUncommittedEvents();
    }
}
