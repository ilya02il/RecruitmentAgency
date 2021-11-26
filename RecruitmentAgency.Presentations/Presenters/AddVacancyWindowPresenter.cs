using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class AddVacancyWindowPresenter : BasePresenter<IAddVacancyView, string>
	{
		private readonly IVacancyService _vacancyService;
		public AddVacancyWindowPresenter(IApplicationController controller, IAddVacancyView view, IVacancyService vacancyService)
			: base(controller, view)
		{
			_vacancyService = vacancyService;

			View.AddVacancy += AddVacancyAsync;
		}

		public override void Run(params string[] arguments)
		{
			View.AgenciesNames = arguments;
			View.Show();
		}

		public async Task AddVacancyAsync()
		{
			await _vacancyService.AddVacancy(View.NewVacancy);
		}
	}
}
