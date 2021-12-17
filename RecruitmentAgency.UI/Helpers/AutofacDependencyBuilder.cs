using Autofac;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecruitmentAgancy.DAL;
using RecruitmentAgency.DAL.Contracts;
using RecruitmentAgency.DAL.Implementations;
using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Models.Implementations;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Presenters;
using RecruitmentAgency.Presentations.Views;
using RecruitmentAgency.UI.Implementations;
using RecruitmentAgency.UI.Profiles;
using System.Windows.Forms;

namespace RecruitmentAgency.UI.Helpers
{
	public static class AutofacDependencyBuilder
	{
		public static IContainer Build()
		{
			var containerBuilder = new ContainerBuilder();

			containerBuilder
				.RegisterType<AdminMainForm>()
				.As<IAdminMainView>()
				.InstancePerDependency();

			containerBuilder
				.RegisterType<EmployerMainForm>()
				.As<IEmployerMainView>()
				.InstancePerDependency();

			containerBuilder
				.RegisterType<LoginForm>()
				.As<ILoginView>()
				.InstancePerDependency();

			containerBuilder
				.RegisterType<RegistrationForm>()
				.As<IRegistrationView>()
				.InstancePerDependency();

			containerBuilder
				.RegisterType<InitializationForm>()
				.As<IInitializationView>()
				.InstancePerDependency();

			containerBuilder
				.RegisterType<AddVacancyForm>()
				.As<IAddView<VacancyModel, string>>()
				.InstancePerDependency();

			containerBuilder
				.Register(context =>
					{
						var builder = new DbContextOptionsBuilder<DataContext>();

						builder.UseSqlServer("Data Source=DESKTOP-3J0KV7C\\SQLEXPRESS;Database=RecruitmentAgencyDb;Integrated Security=True;");

						return new DataContext(builder.Options);
					}
				)
				.AsSelf()
				.InstancePerLifetimeScope();

			containerBuilder
				.RegisterType<EFDbRepository>()
				.As<IDbRepository>()
				.InstancePerDependency();

			containerBuilder
				.Register(context =>
					new MapperConfiguration(cfg => cfg.AddProfile(new MainProfile()))
					);

			containerBuilder
				.Register(context => context.Resolve<MapperConfiguration>().CreateMapper())
				.As<IMapper>()
				.InstancePerLifetimeScope();

			containerBuilder
				.RegisterType<AdminMainWindowPresenter>()
				.AsSelf()
				.SingleInstance();

			containerBuilder
				.RegisterType<EmployerMainWindowPresenter>()
				.AsSelf()
				.SingleInstance();

			containerBuilder
				.RegisterType<LoginWindowPresenter>()
				.AsSelf()
				.InstancePerLifetimeScope();

			containerBuilder
				.RegisterType<RegistrationWindowPresenter>()
				.AsSelf()
				.InstancePerLifetimeScope();

			containerBuilder
				.RegisterType<InitializationWindowPresenter>()
				.AsSelf()
				.InstancePerLifetimeScope();

			containerBuilder
				.RegisterType<AddVacancyWindowPresenter>()
				.AsSelf()
				.InstancePerLifetimeScope();

			containerBuilder
				.RegisterType<UserService>()
				.As<IUserService>()
				.InstancePerLifetimeScope();

			containerBuilder
				.RegisterType<VacancyService>()
				.As<IVacancyService>()
				.InstancePerLifetimeScope();

			containerBuilder
				.RegisterType<EmployerService>()
				.As<IEmployerService>()
				.InstancePerLifetimeScope();

			containerBuilder
				.Register(context => new ApplicationContext())
				.SingleInstance();

			containerBuilder
				.RegisterType<ApplicationController>()
				.As<IApplicationController>()
				.SingleInstance();

			return containerBuilder.Build();
		}
	}
}
