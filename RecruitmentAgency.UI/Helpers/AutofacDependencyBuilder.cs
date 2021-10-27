using Autofac;
using AutoMapper;
using RecruitmentAgancy.DAL;
using RecruitmentAgency.DAL.Contracts;
using RecruitmentAgency.DAL.Implementations;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Models.Implementations;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Presenters;
using RecruitmentAgency.Presentations.Views;
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
				.RegisterType<AddAgencyForm>()
				.As<IAddAgencyView>()
				.InstancePerDependency();

			containerBuilder
				.Register(context => 
					new DataContext()
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
				.InstancePerLifetimeScope();

			containerBuilder
				.RegisterType<AddAgencyWindowPresenter>()
				.AsSelf()
				.InstancePerLifetimeScope();

			containerBuilder
				.RegisterType<AccountService>()
				.As<IAccountService>()
				.InstancePerLifetimeScope();

			containerBuilder
				.RegisterType<AgencyService>()
				.As<IAgencyService>()
				.InstancePerLifetimeScope();

			containerBuilder
				.RegisterType<VacancyService>()
				.As<IVacancyService>()
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
