using RecruitmentAgency.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace RecruitmentAgancy.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<AgencyEntity> Agencies { get; set; }
        public DbSet<CandidateEntity> Candidates { get; set; }
        public DbSet<VacancyEntity> Vacancies { get; set; }
        public DbSet<AgencyCandidateEntity> AgencyCandidates { get; set; }

        public DataContext() : base() { }
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=RecruitmentAgencyDb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RoleEntity>().HasData(
                new RoleEntity { Id = 1, Name = "Admin" },
                new RoleEntity { Id = 2, Name = "Agency" },
                new RoleEntity { Id = 3, Name = "Recruit" }
                );

            builder.Entity<UserEntity>().HasData(
                new UserEntity { Id = 1, Login = "admin", Password = "admin", RoleId = 1 },
                new UserEntity { Id = 2, Login = "agency", Password = "agency", RoleId = 2 },
                new UserEntity { Id = 3, Login = "recruit", Password = "recruit", RoleId = 3 }
                );
        }
    }
}
