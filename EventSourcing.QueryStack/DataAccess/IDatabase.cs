using System.Linq;

namespace EventSourcing.QueryStack.DataAccess
{
    public interface IDatabase
    {
        IQueryable<Booking> Bookings { get; }
        IQueryable<Court> Courts { get; }
    }
}