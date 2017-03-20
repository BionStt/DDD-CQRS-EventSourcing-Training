using System.Collections.Generic;

namespace Deluxe.Infrastructure
{
    public interface IEventStore
    {
        //IEnumerable<T> Find<T>(Func<T, bool> filter);
        IEnumerable<MatchEvent> All(string matchId);

        void Save<T>(T theEvent) where T : EventBase;
    }
}