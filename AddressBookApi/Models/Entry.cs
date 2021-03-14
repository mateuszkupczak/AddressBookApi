using System;

namespace AddressBookApi.Models
{
    public class Entry : EntryDto
	{
		public long Id { get; set; }
		public DateTime CreationDate { get; set; }

		public Entry()
        {
			CreationDate = DateTime.UtcNow;
        }
	}
}
