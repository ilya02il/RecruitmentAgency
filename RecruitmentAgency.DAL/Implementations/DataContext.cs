using RecruitmentAgency.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace RecruitmentAgancy.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<AgencyEntity> Agencies { get; set; }
        public DbSet<CandidateEntity> Candidates { get; set; }
        public DbSet<VacancyEntity> Vacancies { get; set; }
        public DbSet<AgencyCandidateEntity> AgencyCandidates { get; set; }

        public DataContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-3J0KV7C\SQLEXPRESS;Database=RecruitmentAgencyDb;Integrated Security=True;");
        }
    }
}
