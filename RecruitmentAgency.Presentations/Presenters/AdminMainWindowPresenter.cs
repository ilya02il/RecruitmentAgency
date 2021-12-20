using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;
using System.Threading.Tasks;
using System.Linq;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class AdminMainWindowPresenter : BasePresenter<IAdminMainView>
	{
		private readonly IVacancyService _vacancyService;
		private readonly IEmployerService _employerService;

		public AdminMainWindowPresenter(IApplicationController controller, IAdminMainView view, IVacancyService vacancyService, IEmployerService employerService)
			: base(controller, view)
		{
			_vacancyService = vacancyService;
			_employerService = employerService;

			View.AddVacancy += () =>
			{
				var employersNames = _employerService.GetAllEmployers()
					.Select(e => e.Name)
					.ToArray();

                Controller.Run<AddVacancyWindowPresenter, string>(employersNames);
				View.Vacancies = _vacancyService.GetAllVacancies();
			};

			View.DeleteVacancy += DeleteVacancy;
            View.DeleteEmployer += DeleteEmployer;
		}

        public override void Run()
        {
			View.Employers = _employerService.GetAllEmployers();
			View.Vacancies = _vacancyService.GetAllVacancies();
			View.Show();
		}

        //private void EditVacancy(VacancyModel vacancy)
        //{
        //    Controller.Run<EditVacancyWindowPresenter, VacancyModel>(vacancy);
        //    View.Vacancies = _vacancyService.GetAllVacancies();
        //}
        private async Task DeleteVacancy(VacancyModel vacancy)
        {
            await _vacancyService.DeleteVacancy(v => v.Position == vacancy.Position &&
                v.Salary == vacancy.Salary &&
                v.Employer.Name == vacancy.EmployerName);

            View.Vacancies = _vacancyService.GetAllVacancies();
        }

        private async Task DeleteEmployer(EmployerModel employer)
        {
            await _employerService.DeleteEmployer(employer);

            View.Employers = _employerService.GetAllEmployers();
        }
    }
}
