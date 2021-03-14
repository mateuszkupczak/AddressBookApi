using Microsoft.EntityFrameworkCore;

namespace AddressBookApi.Models
{
    public class EntryContext : DbContext
    {
        public EntryContext(DbContextOptions<EntryContext> options)
            : base(options)
        {
        }

        public DbSet<Entry> Entries { get; set; }
    }
}
