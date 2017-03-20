using System.Data.Entity;
using Regular.CommandStack.Model;

namespace Regular.CommandStack
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext()
            : base("name=MerloEntities")
        {
        }

        public virtual DbSet<Match> Matches { get; set; }
    }
}
