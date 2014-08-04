using System.Data.Entity;

namespace K9s.WarriorPortal.Models
{
    public class WarriorPortalDbContext : DbContext
    {
        internal WarriorPortalDbContext()
        {            
        }

        internal WarriorPortalDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {            
        }
    }
}
