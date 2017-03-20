using System;

namespace DomainModel.DomainEvents
{
    public class DomainEvent : Message
    {
        public DateTime TimeStamp { get; private set; }

        public DomainEvent()
        {
            this.TimeStamp = DateTime.Now;
        }
    }
}
