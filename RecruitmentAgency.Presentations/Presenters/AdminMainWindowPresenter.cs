﻿using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;
using System.Threading.Tasks;
using System.Linq;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class AdminMainWindowPresenter : BasePresenter<IAdminMainView>
	{
		private readonly IAgencyService _agencyService;
		private readonly IVacancyService _vacancyService;
		public AdminMainWindowPresenter(IApplicationController controller, IAdminMainView view, IAgencyService agencyService, IVacancyService vacancyService)
			: base(controller, view)
		{
			_agencyService = agencyService;
			_vacancyService = vacancyService;

			View.AddAgency += () =>
			{
				Controller.Run<AddAgencyWindowPresenter>();
				View.Agencies = _agencyService.GetAllAgencies();
			};

			View.AddVacancy += () =>
			{
				var agenciesNames = _agencyService.GetAllAgencies().Select(a => a.Name).ToArray();

                Controller.Run<AddVacancyWindowPresenter, string>(agenciesNames);
				View.Vacancies = _vacancyService.GetAllVacancies();
			};

			View.EditAgency += EditAgency;
			View.DeleteAgency += DeleteAgency;
			View.DeleteVacancy += DeleteVacancy;
		}

        public override void Run()
        {
			View.Agencies = _agencyService.GetAllAgencies();
			View.Vacancies = _vacancyService.GetAllVacancies();
			View.Show();
		}

		private void EditAgency(AgencyModel agency)
        {
			Controller.Run<EditAgencyWindowPresenter, AgencyModel>(agency);
			View.Agencies = _agencyService.GetAllAgencies();
        }
        private async Task DeleteAgency(AgencyModel agency)
        {
			await _agencyService.DeleteAgency(a => a.Name == agency.Name);
			View.Agencies = _agencyService.GetAllAgencies();
		}

		//private void EditVacancy(VacancyModel vacancy)
		//{
		//	Controller.Run<EditVacancyWindowPresenter, VacancyModel>(vacancy);
		//	View.Vacancies = _vacancyService.GetAllVacancies();
		//}
		private async Task DeleteVacancy(VacancyModel vacancy)
		{
			await _vacancyService.DeleteVacancy(v => v.Position == vacancy.Position &&
				v.Salary == vacancy.Salary &&
				v.Agency.Name == vacancy.AgencyName);

			View.Vacancies = _vacancyService.GetAllVacancies();
		}
	}
}
