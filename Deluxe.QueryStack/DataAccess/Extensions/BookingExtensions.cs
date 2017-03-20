using System.Linq;

namespace Deluxe.QueryStack.DataAccess.Extensions 
{
    public static class BookingExtensions
    {
        public static IQueryable<Booking> ForCourts(this IQueryable<Booking> bookings, params int[] courtIds)
        {
            return bookings.Where(b => courtIds.Contains(b.CourtId));
        }
    }
}