using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatkudumusr.Data;
using RecruitCatkudumusr.Models;

namespace RecruitCatkudumusr.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatkudumusr.Data.RecruitCatkudumusrContext _context;

        public IndexModel(RecruitCatkudumusr.Data.RecruitCatkudumusrContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate.ToListAsync();
        }
    }
}
