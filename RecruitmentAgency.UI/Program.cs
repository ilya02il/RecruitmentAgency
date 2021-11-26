using Autofac;
using RecruitmentAgancy.DAL;
using RecruitmentAgency.DAL.Entities;
using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Presenters;
using RecruitmentAgency.UI.Helpers;
using System;
using System.Windows.Forms;

namespace RecruitmentAgency.UI
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>

		private static IApplicationController _controller;

		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			var container = AutofacDependencyBuilder.Build();

			using var scope = container.BeginLifetimeScope();

			_controller = scope.Resolve<IApplicationController>();
			_controller.Run<AdminMainWindowPresenter, UserModel>();

			//var dbContext = new DataContext();

			//dbContext.Add(new AgencyEntity()
			//{
			//	Name = "Трудовичок"
			//});

			//dbContext.SaveChanges();

			//var dbContext = new DataContext();

			//dbContext.Add(new VacancyEntity()
			//{
			//	Position = "Программист",
			//	Salary = 45000,
			//	AgencyId = 1
			//});

			//dbContext.SaveChanges();
		}
	}
}
