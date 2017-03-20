using System.Linq;

namespace EventSourcing.QueryStack.DataAccess
{
    public class Database : IDatabase
    {
        private readonly expoware_MerloEntities _merlo;
        public Database()
        {
            _merlo = new expoware_MerloEntities();
        }

        public IQueryable<Booking> Bookings
        {
            get
            {
                return _merlo.Bookings; 
            }
        }

        public IQueryable<Court> Courts
        {
            get
            {
                return _merlo.Courts;
            }
        }
    }
}