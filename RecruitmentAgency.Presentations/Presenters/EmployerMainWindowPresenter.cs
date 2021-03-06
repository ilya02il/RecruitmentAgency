using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class EmployerMainWindowPresenter : BasePresenter<IEmployerMainView, EmployerModel>
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
            };

            View.DeleteVacancy += DeleteVacancy;
            View.ShowCandidates += vacancy => Controller.Run<ShowCandidatesEmployerWindowPresenter, VacancyModel>(vacancy);
        }

        public override void Run(params EmployerModel[] arguments)
        {
            View.CurrentEmployer = arguments[0];

            View.Vacancies = _vacancyService.GetAllVacancies()
                .Where(v => v.EmployerName == arguments[0].Name);

            View.Show();
        }

        public override void Run(EmployerModel argument)
        {
            View.CurrentEmployer = argument;

            View.Vacancies = _vacancyService.GetAllVacancies()
                .Where(v => v.EmployerName == argument.Name);

            View.Show();
        }

        private async Task DeleteVacancy(VacancyModel vacancy)
        {
            await _vacancyService.DeleteVacancy(vacancy);

            View.Vacancies = _vacancyService.GetAllVacancies()
                .Where(v => v.EmployerName == View.CurrentEmployer.Name);
        }
    }
}
