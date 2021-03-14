using System;
using AddressBookApi.Models;

namespace AddressBookApi.UnitTests
{
    public static class DbContextExtensions
    {
        public static void Seed(this EntryContext dbContext)
        {
            long id = 0;

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2019, 3, 15),
                FullName = "Ryszard Kowalski",
                Street = "ul. Pocztowa 55",
                PostalCode = "99-990",
                Town = "Bañka nad Dunajcem",
                Country = "Poland"
            });

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2019, 3, 28),
                FullName = "Barbara Dobrowolska",
                Street = "ul. Domniemana 27/2",
                PostalCode = "68-868",
                Town = "Fio³ków-Dobrzany",
                Country = "Poland"
            });

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2019, 3, 29),
                FullName = "Milena Stañczyk",
                Street = "ul. Mi³a 7",
                PostalCode = "68-868",
                Town = "Fio³ków-Dobrzany",
                Country = "Poland"
            });

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2019, 3, 29),
                FullName = "Alicja Ryœ",
                Street = "ul. Spokojna 39",
                PostalCode = "20-001",
                Town = "¯erowice",
                Country = "Poland"
            });

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2019, 4, 2),
                FullName = "Damian P³atek",
                Street = "ul. Spokojna 42",
                PostalCode = "20-001",
                Town = "¯erowice",
                Country = "Poland"
            });

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2019, 9, 18),
                FullName = "Marcin Mi³osz",
                Street = "al. Niepodleg³oœci 18/10",
                PostalCode = "68-869",
                Town = "Fio³ków-Dobrzany",
                Country = "Poland"
            });

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2020, 2, 7),
                FullName = "Andrzej Puta³t",
                Street = "ul. Leœna 2",
                PostalCode = "91-111",
                Town = "Klony",
                Country = "Poland"
            });

            dbContext.SaveChanges();
        }
    }
}
