using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatkudumusr.Models;

namespace RecruitCatkudumusr.Data
{
    public class RecruitCatkudumusrContext : DbContext
    {
        public RecruitCatkudumusrContext (DbContextOptions<RecruitCatkudumusrContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatkudumusr.Models.Candidate> Candidate { get; set; } = default!;
        public DbSet<RecruitCatkudumusr.Models.Company> Company { get; set; } = default!;
        public DbSet<RecruitCatkudumusr.Models.Industry> Industry { get; set; } = default!;
        public DbSet<RecruitCatkudumusr.Models.JobTitle> JobTitle { get; set; } = default!;
    }
}
