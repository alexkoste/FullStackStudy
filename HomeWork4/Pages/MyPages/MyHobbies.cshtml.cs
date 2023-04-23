using HomeWork4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWork4.Pages.MyPages
{
    public class MyHobbiesModel : PageModel
    {
		public List<Hobby> Hobbies { get; set; } = new List<Hobby>();

		public async Task OnGetAsync()
		{
			Hobbies.Add(new Hobby() { Name = "Reading", StartDate = "01/01/1995", Description = "Reading different books." });
			Hobbies.Add(new Hobby() { Name = "Riding", StartDate = "01/05/2015", Description = "Riding on a bike." });
			Hobbies.Add(new Hobby() { Name = "Traveling", StartDate = "01/07/2012", Description = "Discovering new interesting places." });

		}
	}
}
