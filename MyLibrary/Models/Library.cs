using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    public class Library
    {
        [Key]
        public int LibraryId { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Address { get; set; }

        public string OpenHour { get; set; }

        public string CloseHour { get; set; }

        public virtual ICollection<Book> Books { get; set; }

		public virtual ICollection<LibraryPatron> Patrons { get; set; }
	}
}
