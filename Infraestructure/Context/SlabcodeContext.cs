using Domain.Entities.ProjectAggregate;
using Domain.Entities.UserAggregate;
using Infraestructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Context
{
    public class SlabcodeContext : DbContext
    {
        #region Constructor
        public SlabcodeContext() : base()
        {

        }
        #endregion

        #region DbSets
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion

        #region DbContext Overrides
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());

        }
        
        #endregion
    }
}
