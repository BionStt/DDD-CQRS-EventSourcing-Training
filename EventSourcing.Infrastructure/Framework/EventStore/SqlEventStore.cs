﻿using System.Collections.Generic;

namespace EventSourcing.Infrastructure.Framework.EventStore
{
    public class SqlEventStore : IEventStore
    {
        private static readonly EventRepository EventRepository = new EventRepository();

        public IEnumerable<Event> All(string matchId)
        {
            return null; //EventRepository.All(matchId);
        }

        public void Save<T>(T theEvent) where T : Event
        {
            var loggedEvent = new LoggedEvent()
            {
                Action = theEvent.Name,
                AggregateId = theEvent.SagaId,
                Cargo = new JavaScriptSerializer().Serialize(theEvent)
            };

            EventRepository.Store(loggedEvent);
        }
    }
}