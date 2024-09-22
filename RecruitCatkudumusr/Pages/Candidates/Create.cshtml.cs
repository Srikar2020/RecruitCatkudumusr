using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatkudumusr.Data;
using RecruitCatkudumusr.Models;

namespace RecruitCatkudumusr.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatkudumusr.Data.RecruitCatkudumusrContext _context;

        public CreateModel(RecruitCatkudumusr.Data.RecruitCatkudumusrContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
