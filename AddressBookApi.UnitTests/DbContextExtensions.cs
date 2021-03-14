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
                Town = "Ba�ka nad Dunajcem",
                Country = "Poland"
            });

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2019, 3, 28),
                FullName = "Barbara Dobrowolska",
                Street = "ul. Domniemana 27/2",
                PostalCode = "68-868",
                Town = "Fio�k�w-Dobrzany",
                Country = "Poland"
            });

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2019, 3, 29),
                FullName = "Milena Sta�czyk",
                Street = "ul. Mi�a 7",
                PostalCode = "68-868",
                Town = "Fio�k�w-Dobrzany",
                Country = "Poland"
            });

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2019, 3, 29),
                FullName = "Alicja Ry�",
                Street = "ul. Spokojna 39",
                PostalCode = "20-001",
                Town = "�erowice",
                Country = "Poland"
            });

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2019, 4, 2),
                FullName = "Damian P�atek",
                Street = "ul. Spokojna 42",
                PostalCode = "20-001",
                Town = "�erowice",
                Country = "Poland"
            });

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2019, 9, 18),
                FullName = "Marcin Mi�osz",
                Street = "al. Niepodleg�o�ci 18/10",
                PostalCode = "68-869",
                Town = "Fio�k�w-Dobrzany",
                Country = "Poland"
            });

            dbContext.Entries.Add(new Entry
            {
                Id = ++id,
                CreationDate = new DateTime(2020, 2, 7),
                FullName = "Andrzej Puta�t",
                Street = "ul. Le�na 2",
                PostalCode = "91-111",
                Town = "Klony",
                Country = "Poland"
            });

            dbContext.SaveChanges();
        }
    }
}
