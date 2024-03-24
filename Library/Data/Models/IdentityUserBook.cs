using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Library.Data.Models
{
	[Comment("User Books")]
	public class IdentityUserBook
	{
		[Comment("Book Collector")]
		public string CollectorId { get; set; } = null!;

		[Comment("Collector")]
		public IdentityUser IdentityUser { get; set; } = null!;

		[Comment("Book Id")]
		public int BookId { get; set; }

		[Comment("Book")]
		public Book Book { get; set; } = null!;
	}
}