using AddressBookApi.Models;
using AutoMapper;

namespace AddressBookApi
{
    public class EntryProfile : Profile
    {
        public EntryProfile()
        {
            CreateMap<EntryDto, Entry>();
        }
    }
}
