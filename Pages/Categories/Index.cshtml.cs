using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Todea_Denisa_Lab2.Data;
using Todea_Denisa_Lab2.Models;

namespace Todea_Denisa_Lab2.Pages.Categories
{
    [Authorize(Roles = "Admin")]

    public class IndexModel : PageModel
    {
        private readonly Todea_Denisa_Lab2.Data.Todea_Denisa_Lab2Context _context;

        public IndexModel(Todea_Denisa_Lab2.Data.Todea_Denisa_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
