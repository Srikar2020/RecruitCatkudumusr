using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatkudumusr.Data;
using RecruitCatkudumusr.Models;

namespace RecruitCatkudumusr.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatkudumusr.Data.RecruitCatkudumusrContext _context;

        public DetailsModel(RecruitCatkudumusr.Data.RecruitCatkudumusrContext context)
        {
            _context = context;
        }

        public Company Company { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _context.Company.FirstOrDefaultAsync(m => m.Id == id);
            if (company == null)
            {
                return NotFound();
            }
            else
            {
                Company = company;
            }
            return Page();
        }
    }
}
