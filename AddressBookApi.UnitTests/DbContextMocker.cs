using AddressBookApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBookApi.UnitTests
{
    public static class DbContextMocker
    {
        public static EntryContext GetEntryContext(string dbName)
        {
            var options = new DbContextOptionsBuilder<EntryContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            var dbContext = new EntryContext(options);

            dbContext.Seed();

            return dbContext;
        }
    }
}
