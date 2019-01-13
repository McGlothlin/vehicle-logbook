using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Logbook.Data;
using Logbook.Data.Models;

namespace Logbook.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Logbook.Data.ApplicationDbContext _context;

        public DetailsModel(Logbook.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Vehicle Vehicle { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vehicle = await _context.Vehicles.FirstOrDefaultAsync(m => m.Id == id);

            if (Vehicle == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
