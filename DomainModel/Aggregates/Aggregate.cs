using System;

namespace DomainModel.Aggregates
{
    public abstract class Aggregate : IAggregate
    {
        public Guid Id { get; protected set; }

        Guid IAggregate.Id
        {
            get
            {
                return Id;
            }
        }
    }
}
