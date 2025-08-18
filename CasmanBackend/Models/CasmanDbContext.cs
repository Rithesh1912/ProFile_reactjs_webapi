using Microsoft.EntityFrameworkCore;

namespace CasmanSln.Models
{
    public class CasmanDbContext:DbContext
    {
       public CasmanDbContext(DbContextOptions<CasmanDbContext>options):base(options) { }

        public DbSet<Case> t_case {  get; set; }
        public DbSet<CasePractioner> t_case_prac {  get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<CaseType> caseType { get; set; }
        public DbSet<MduLiability> mduLiability { get; set; }
        public DbSet<PracArea> pracArea { get; set; }

        public DbSet<Area> area { get; set; }
        public DbSet<Specialty> specialties { get; set; }

        public DbSet<Country> country { get; set; }

    }
}
