using System;
using System.Linq;
using Regular.ReadStack.Model;

namespace Regular.ReadStack
{
    public class Database : IDisposable
    {
        private readonly QueryDbContext _context = new QueryDbContext();

        public IQueryable<Match> Matches
        {
            get
            {
                return _context.Matches;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}