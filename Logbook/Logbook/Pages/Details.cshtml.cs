using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Logbook.Models;

namespace Logbook.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Logbook.Models.ApplicationDbContext _context;

        public DetailsModel(Logbook.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public Vehicle Vehicle { get; set; }

        public ICollection<ServiceItem> ServiceItems { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vehicle = await _context.Vehicles.FirstOrDefaultAsync(m => m.Id == id);
            ServiceItems = await _context.ServiceItems.Where(m => m.VehicleId == Vehicle.Id).ToListAsync();

            if (Vehicle == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
