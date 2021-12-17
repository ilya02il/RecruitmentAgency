using RecruitmentAgency.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace RecruitmentAgancy.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<CandidateInfoEntity> CandidatesInfo { get; set; }
        public DbSet<EmployerInfoEntity> EmployersInfo { get; set; }
        public DbSet<VacancyEntity> Vacancies { get; set; }
        public DbSet<VacancyCandidatesEntity> VacancyCandidates { get; set; }

        public DataContext() : base() { }
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-3J0KV7C\\SQLEXPRESS;Database=RecruitmentAgencyDb;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RoleEntity>().HasData(
                new RoleEntity { Id = 1, Name = "Admin" },
                new RoleEntity { Id = 2, Name = "Employer" },
                new RoleEntity { Id = 3, Name = "Candidate" }
                );

            builder.Entity<UserEntity>().HasData(
                new UserEntity { Id = 1, Login = "admin", Password = "admin", RoleId = 1 },
                new UserEntity { Id = 2, Login = "employer", Password = "employer", RoleId = 2 },
                new UserEntity { Id = 3, Login = "candidate", Password = "candidate", RoleId = 3 }
                );
        }
    }
}
