using System.Data.Entity;
using Regular.ReadStack.Model;

namespace Regular.ReadStack
{
    class QueryDbContext : DbContext
    {
        public QueryDbContext()
            : base("name=MerloEntities")
        {
        }

        public virtual DbSet<Match> Matches { get; set; }
    }
}
