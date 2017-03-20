using System;

namespace DomainModel.Aggregates
{
    public interface IAggregate 
    {
        Guid Id { get; }
    }
}
