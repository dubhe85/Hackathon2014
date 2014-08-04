using System.Data.Entity.Infrastructure;

namespace K9s.WarriorPortal.Models
{
    public class WarriorPortalDbContextFactory : IDbContextFactory<WarriorPortalDbContext>
    {
        public WarriorPortalDbContext Create()
        {
            return new WarriorPortalDbContext();
        }
    }
}
