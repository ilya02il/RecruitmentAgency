using RecruitmentAgency.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

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
            builder.Entity<UserEntity>()
                .HasOne(u => u.CandidateInfo)
                .WithOne(ci => ci.User)
                .HasForeignKey<CandidateInfoEntity>(ci => ci.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserEntity>()
                .HasOne(u => u.EmployerInfo)
                .WithOne(ei => ei.User)
                .HasForeignKey<EmployerInfoEntity>(ei => ei.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<VacancyCandidatesEntity>()
                .HasKey(vc => new { vc.VacancyId, vc.CandidateId });

            builder.Entity<VacancyCandidatesEntity>()
                .HasOne(vc => vc.Vacancy)
                .WithMany(v => v.VacancyCandidates)
                .HasForeignKey(vc => vc.VacancyId);

            builder.Entity<VacancyCandidatesEntity>()
                .HasOne(vc => vc.Candidate)
                .WithMany(c => c.VacancyCandidates)
                .HasForeignKey(vc => vc.CandidateId);


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

            builder.Entity<EmployerInfoEntity>().HasData(
                new EmployerInfoEntity
                {
                    Id = 1,
                    Name = "Трудовичок",
                    UserId = 2
                }
                );

            builder.Entity<CandidateInfoEntity>().HasData(
                new CandidateInfoEntity
                {
                    Id = 1,
                    Initials = "Иванов Иван Иванович",
                    DateOfBirth = DateTime.Now,
                    UserId = 3
                }
                );
        }
    }
}
