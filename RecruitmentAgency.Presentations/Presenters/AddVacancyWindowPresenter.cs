using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class AddVacancyWindowPresenter : BasePresenter<IAddView<VacancyModel, string>, string>
	{
		private readonly IVacancyService _vacancyService;
		public AddVacancyWindowPresenter(IApplicationController controller, IAddView<VacancyModel, string> view, IVacancyService vacancyService)
			: base(controller, view)
		{
			_vacancyService = vacancyService;

			View.Add += AddVacancyAsync;
		}

		public override void Run(params string[] arguments)
		{
			View.Arguments = arguments;
			View.Show();
		}

		public async Task AddVacancyAsync()
		{
			await _vacancyService.AddVacancy(View.NewModel);
		}

        public override void Run(string argument)
        {
			var strArray = new string[] { argument };

			View.Arguments = strArray;
			View.Show();
		}
    }
}
