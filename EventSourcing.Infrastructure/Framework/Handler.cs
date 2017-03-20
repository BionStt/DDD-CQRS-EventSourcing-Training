using System;

namespace EventSourcing.Infrastructure.Framework
{
    public abstract class Handler
    {
        public EventStore.IEventStore EventStore { get; private set; }


        public Handler(EventStore.IEventStore eventStore)
        {
            if (eventStore == null)
            {
                throw new ArgumentNullException("eventStore");
            }

            EventStore = eventStore;
        }
    }

}