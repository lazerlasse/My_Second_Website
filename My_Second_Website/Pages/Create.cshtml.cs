using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace My_Second_Website.Pages
{
    public class CreateModel : PageModel
    {
		private readonly AppDbContext _db;
		private ILogger<CreateModel> Log; /* Create a log of crete model */

		public CreateModel(AppDbContext db, ILogger<CreateModel> log)
		{
			_db = db;
			Log = log;
		}

		[BindProperty] /* Mark this as binding propperty */
		public Customer Customer { get; set; }

		[TempData] /* Creates a message as tempdata!*/
		public string Message { get; set; }

        public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid) return Page();

			_db.Customers.Add(Customer);
			await _db.SaveChangesAsync();
			string msg = $"Customer {Customer.Name} Added!";
			Message = msg;
			Log.LogInformation(msg); /* Set new customer added in the log */
			return RedirectToPage("/Index");
		}
    }
}