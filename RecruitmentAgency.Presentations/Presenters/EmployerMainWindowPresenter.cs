using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;
using System;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class EmployerMainWindowPresenter : BasePresenter<IEmployerMainView>
    {
        private readonly IVacancyService _vacancyService;

        public EmployerMainWindowPresenter(IApplicationController controller, IEmployerMainView view, IVacancyService vacancyService)
            : base(controller, view)
        {
            _vacancyService = vacancyService;

            View.AddVacancy += () =>
            {
                Controller.Run<AddVacancyWindowPresenter, string>(Array.Empty<string>());
                View.Vacancies = _vacancyService.GetAllVacancies();

                View.DeleteVacancy += DeleteVacancy;
            };
        }

        public override void Run()
        {
            View.Vacancies = _vacancyService.GetAllVacancies();
            View.Show();
        }

        private async Task DeleteVacancy(VacancyModel vacancy)
        {
            await _vacancyService.DeleteVacancy(v => v.Position == vacancy.Position &&
                v.Salary == vacancy.Salary &&
                v.Employer.Name == vacancy.EmployerName);

            View.Vacancies = _vacancyService.GetAllVacancies();
        }
    }
}
