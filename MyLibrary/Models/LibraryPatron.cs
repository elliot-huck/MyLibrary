using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
	public class LibraryPatron
	{
		[Key]
		public int LibraryPatronId { get; set; }

		public int LibraryId { get; set; }

		public Library Library { get; set; }

		public int PatronId { get; set; }

		public Patron Patron { get; set; }
	}
}
