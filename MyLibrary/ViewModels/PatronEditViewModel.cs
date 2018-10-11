using Microsoft.AspNetCore.Mvc.Rendering;
using MyLibrary.Data;
using MyLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.ViewModels
{
	public class PatronEditViewModel
	{
		public Patron Patron { get; set; }

		public List<SelectListItem> AllLibraries { get; set; }

		public List<string> MemberLibraries { get; set; }

		public List<LibraryPatron> Intersections { get; set; }

		public PatronEditViewModel();

		public PatronEditViewModel(ApplicationDbContext context, int? id)
		{
			AllLibraries = context.Library.Select(library =>
			new SelectListItem { Text = library.Name, Value = library.LibraryId.ToString() }).ToList();

			Intersections = context.LibraryPatron.Where(intersection => intersection.PatronId == id).ToList();

			MemberLibraries = Intersections.Select(intersection => intersection.LibraryId.ToString()).ToList();
		}
	}
}
