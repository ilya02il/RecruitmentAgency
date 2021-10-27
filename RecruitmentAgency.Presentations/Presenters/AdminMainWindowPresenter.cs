using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;

namespace RecruitmentAgency.Presentations.Presenters
{
	public class AdminMainWindowPresenter : BasePresenter<IAdminMainView, UserModel>
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
				Controller.Run<AddAgencyWindowPresenter, AgencyModel>();
				View.Agencies = _agencyService.GetAllAgencies();
			};
		}

		public override void Run(params UserModel[] arguments)
		{
			View.Agencies = _agencyService.GetAllAgencies();
			View.Vacancies = _vacancyService.GetAllVacancies();
			View.Show();
		}
	}
}
