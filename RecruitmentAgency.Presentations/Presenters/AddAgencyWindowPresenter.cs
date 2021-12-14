using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Presenters
{
	public class AddAgencyWindowPresenter : BasePresenter<IAddView<AgencyModel>>
	{
		private readonly IAgencyService _agencyService;
		public AddAgencyWindowPresenter(IApplicationController controller, IAddView<AgencyModel> view, IAgencyService agencyService)
			: base(controller, view)
		{
			_agencyService = agencyService;

			View.Add += AddAgencyAsync;
		}

		private async Task AddAgencyAsync()
		{
			await _agencyService.AddAgency(View.NewModel);
		}
	}
}
