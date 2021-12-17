using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class CandidateMainWindowPresenter : BasePresenter<ICandidateMainView, CandidateModel>
    {
        private readonly IVacancyService _vacancyService;
        private CandidateModel _currentCandidate;

        public CandidateMainWindowPresenter(IApplicationController controller, ICandidateMainView view, IVacancyService vacancyService)
            : base(controller, view)
        {
            _vacancyService = vacancyService;

            View.RespondToVacancy += vacancy =>
            {

            };
        }

        public override void Run(params CandidateModel[] arguments)
        {
            _currentCandidate = arguments[0];

            View.Vacancies = _vacancyService.GetAllVacancies();
        }

        public override void Run(CandidateModel argument)
        {
            _currentCandidate = argument;

            View.Vacancies = _vacancyService.GetAllVacancies();
        }
    }
}
