using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class ShowCandidatesEmployerWindowPresenter
        : BasePresenter<IShowCandidatesEmployerView, VacancyModel>
    {
        private readonly IVacancyService _vacancyService;

        public ShowCandidatesEmployerWindowPresenter(IApplicationController controller, IShowCandidatesEmployerView view, IVacancyService vacancyService) : base(controller, view)
        {
            _vacancyService = vacancyService;
        }

        public override void Run(params VacancyModel[] arguments)
        {
            if (arguments.Length == 0)
            {
                View.Show();
                return;
            }

            View.Candidates = _vacancyService.GetVacancyCandidates(arguments[0]);

            View.Show();
        }

        public override void Run(VacancyModel argument)
        {
            View.Candidates = _vacancyService.GetVacancyCandidates(argument);

            View.Show();
        }
    }
}
