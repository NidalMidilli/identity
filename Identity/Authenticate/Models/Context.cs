using Microsoft.EntityFrameworkCore;

namespace Authenticate.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-RPBUNGP\SQLEXPRESS;Database=Auth;Trusted_Connection=true;");
        }

        public DbSet<Admin> Admins { get; set; }
    }
}
