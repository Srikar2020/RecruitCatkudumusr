using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatkudumusr.Data;
using RecruitCatkudumusr.Models;

namespace RecruitCatkudumusr.Pages.Companies
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
        public Company Company { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _context.Company.Add(Company);
                await _context.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes: " + ex.Message);
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
