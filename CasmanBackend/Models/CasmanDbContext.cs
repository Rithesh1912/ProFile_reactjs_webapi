using Microsoft.EntityFrameworkCore;

namespace CasmanSln.Models
{
    public class CasmanDbContext:DbContext
    {
       public CasmanDbContext(DbContextOptions<CasmanDbContext>options):base(options) { }

        public DbSet<Case> t_case {  get; set; }
        public DbSet<CasePractioner> t_case_prac {  get; set; }
        public DbSet<Category> t_Category { get; set; }

        public DbSet<CaseType> t_caseType { get; set; }
        public DbSet<MduLiability> t_mduLiability { get; set; }
        public DbSet<PracArea> t_pracArea { get; set; }

        public DbSet<Area> t_area { get; set; }
        public DbSet<Specialty> t_specialties { get; set; }

        public DbSet<Country> t_country { get; set; }

        public DbSet<adv_team> t_adv_team {  get; set; }

        public DbSet<app_user> t_app_user { get; set; }

        public DbSet<Staff>t_staff { get; set; }

        public DbSet<Department> t_dept {  get; set; }

        public DbSet<Indemnifier> t_def_org { get; set; }

        public DbSet<Specialty> t_spclty { get; set; }

        public DbSet<Status> t_case_stat { get; set; }

        public DbSet<CasePractice> t_case_practice {  get; set; }

        public DbSet<FileClassification> t_file_classification { get; set; }


    }
}
