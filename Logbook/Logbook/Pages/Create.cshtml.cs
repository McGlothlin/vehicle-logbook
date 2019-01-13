using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Logbook.Data;
using Logbook.Data.Models;

namespace Logbook.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Logbook.Data.ApplicationDbContext _context;

        public CreateModel(Logbook.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Vehicle Vehicle { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vehicles.Add(Vehicle);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}