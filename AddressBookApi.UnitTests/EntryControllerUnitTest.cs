using System.Collections.Generic;
using System.Threading.Tasks;
using AddressBookApi.Controllers;
using AddressBookApi.Models;
using AutoMapper;
using Xunit;

namespace AddressBookApi.UnitTests
{
    public class EntryControllerUnitTest
    {
        private static IMapper _mapper;

        public EntryControllerUnitTest()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new EntryProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
        }

        [Fact]
        public async Task TestGetLastEntry()
        {
            var dbContext = DbContextMocker.GetEntryContext(nameof(TestGetLastEntry));
            var controller = new EntriesController(dbContext, _mapper, null);

            var response = await controller.GetLastEntry();
            var value = response.Value;

            Assert.True(value != null && value.FullName == "Andrzej Putałt");
        }

        [Fact]
        public async Task TestGetEntriesForTown()
        {
            var dbContext = DbContextMocker.GetEntryContext(nameof(TestGetEntriesForTown));
            var controller = new EntriesController(dbContext, _mapper, null);

            var townCounts = new Dictionary<string, int>
            {
                { "Bańka nad Dunajcem", 1 },
                { "fiołków-dobrzany", 3 },
                { "ŻEROWICE", 2 },
                { "kLoNy", 1 },
            };
            foreach (var townCount in townCounts)
            {
                var response = await controller.GetEntriesForTown(townCount.Key);
                var value = response.Value as List<Entry>;

                Assert.True(value != null && value.Count == townCount.Value);
            }
        }

        [Fact]
        public async Task TestPostEntry()
        {
            var dbContext = DbContextMocker.GetEntryContext(nameof(TestPostEntry));
            var controller = new EntriesController(dbContext, _mapper, null);

            var newEntry = new EntryDto
            {
                FullName = "Дмитрий Верович",
                Street = "Дальняя ул. 73",
                PostalCode = "109999",
                Town = "Кодкутск",
                Country = "Russia"
            };
            var query = await controller.PostEntry(newEntry);
            var response = await controller.GetLastEntry();
            var value = response.Value;

            Assert.True(value != null && value.FullName == "Дмитрий Верович");
        }
    }
}
