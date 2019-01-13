using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Logbook.Models;
using Logbook.Models;

namespace Logbook.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Logbook.Models.ApplicationDbContext _context;

        public IndexModel(Logbook.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Vehicle> Vehicle { get;set; }

        public async Task OnGetAsync()
        {
            Vehicle = await _context.Vehicles.ToListAsync();
        }
    }
}
