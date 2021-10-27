using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Presenters
{
	public class AddAgencyWindowPresenter : BasePresenter<IAddAgencyView, AgencyModel>
	{
		private readonly IAgencyService _agencyService;
		public AddAgencyWindowPresenter(IApplicationController controller, IAddAgencyView view, IAgencyService agencyService)
			: base(controller, view)
		{
			_agencyService = agencyService;

			View.AddAgency += AddAgencyAsync;
		}

		public override void Run(params AgencyModel[] arguments)
		{
			View.Show();
		}

		public async Task AddAgencyAsync()
		{
			await _agencyService.AddAgency(View.NewAgency);
		}
	}
}
