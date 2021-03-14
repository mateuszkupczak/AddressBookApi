using System.ComponentModel.DataAnnotations;

namespace AddressBookApi.Models
{
    public class EntryDto
    {
		[Required]
		[MaxLength(100)]
		public string FullName { get; set; }
		[Required]
		[MaxLength(100)]
		public string Street { get; set; }
		[Required]
		[MaxLength(20)]
		public string PostalCode { get; set; }
		[Required]
		[MaxLength(100)]
		public string Town { get; set; }
		[Required]
		[MaxLength(100)]
		public string Country { get; set; }
	}
}
