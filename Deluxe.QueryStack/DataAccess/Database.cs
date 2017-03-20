using System.Linq;

namespace Deluxe.QueryStack.DataAccess
{
    public class Database : IDatabase
    {
        private readonly MerloEntities _merlo;
        public Database()
        {
            _merlo = new MerloEntities();
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