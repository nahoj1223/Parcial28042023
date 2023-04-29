using Microsoft.EntityFrameworkCore;
using EntryControl.Shared.Entities;

namespace EntryControl.API.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(x => x.IdTicket).IsUnique();
        }
    }
}
