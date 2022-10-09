using Microsoft.EntityFrameworkCore;

namespace LegoasAssignment.Models.SQLServer
{
    public class LegoasDbContext : DbContext
    {
        public LegoasDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Screen> Screens { get; set; }
    }
}
