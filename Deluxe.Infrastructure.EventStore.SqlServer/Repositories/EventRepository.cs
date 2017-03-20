using System;
using Deluxe.Infrastructure.EventStore.SqlServer.Data;

namespace Deluxe.Infrastructure.EventStore.SqlServer.Repositories
{
    public class EventRepository
    {
        private readonly MerloEventStore _db = new MerloEventStore();

        public void Store(LoggedEvent eventToLog)
        {
            eventToLog.TimeStamp = DateTime.Now;
            _db.LoggedEvents.Add(eventToLog);
            _db.SaveChanges();
        }
    }
}