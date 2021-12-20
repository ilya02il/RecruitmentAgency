﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruitmentAgancy.DAL;

namespace RecruitmentAgency.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211219115441_ChangeSomeIssues")]
    partial class ChangeSomeIssues
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.CandidateInfoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Initials")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("CandidatesInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2021, 12, 19, 18, 54, 40, 990, DateTimeKind.Local).AddTicks(7144),
                            Initials = "Иванов Иван Иванович",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.EmployerInfoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("EmployersInfo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Трудовичок",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Employer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Candidate"
                        });
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "admin",
                            Password = "admin",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Login = "employer",
                            Password = "employer",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 3,
                            Login = "candidate",
                            Password = "candidate",
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.VacancyCandidatesEntity", b =>
                {
                    b.Property<int>("VacancyId")
                        .HasColumnType("int");

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.HasKey("VacancyId", "CandidateId");

                    b.HasIndex("CandidateId");

                    b.ToTable("VacancyCandidates");
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.VacancyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployerId")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployerId");

                    b.ToTable("Vacancies");
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.CandidateInfoEntity", b =>
                {
                    b.HasOne("RecruitmentAgency.DAL.Entities.UserEntity", "User")
                        .WithOne("CandidateInfo")
                        .HasForeignKey("RecruitmentAgency.DAL.Entities.CandidateInfoEntity", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.EmployerInfoEntity", b =>
                {
                    b.HasOne("RecruitmentAgency.DAL.Entities.UserEntity", "User")
                        .WithOne("EmployerInfo")
                        .HasForeignKey("RecruitmentAgency.DAL.Entities.EmployerInfoEntity", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.UserEntity", b =>
                {
                    b.HasOne("RecruitmentAgency.DAL.Entities.RoleEntity", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.VacancyCandidatesEntity", b =>
                {
                    b.HasOne("RecruitmentAgency.DAL.Entities.CandidateInfoEntity", "Candidate")
                        .WithMany("VacancyCandidates")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecruitmentAgency.DAL.Entities.VacancyEntity", "Vacancy")
                        .WithMany("VacancyCandidates")
                        .HasForeignKey("VacancyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("Vacancy");
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.VacancyEntity", b =>
                {
                    b.HasOne("RecruitmentAgency.DAL.Entities.EmployerInfoEntity", "Employer")
                        .WithMany()
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employer");
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.CandidateInfoEntity", b =>
                {
                    b.Navigation("VacancyCandidates");
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.RoleEntity", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.UserEntity", b =>
                {
                    b.Navigation("CandidateInfo");

                    b.Navigation("EmployerInfo");
                });

            modelBuilder.Entity("RecruitmentAgency.DAL.Entities.VacancyEntity", b =>
                {
                    b.Navigation("VacancyCandidates");
                });
#pragma warning restore 612, 618
        }
    }
}
