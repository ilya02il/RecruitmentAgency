using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class InitializationWindowPresenter : BasePresenter<IInitializationView>
    {
		private readonly IUserService _service;
		public InitializationWindowPresenter(IApplicationController controller, IInitializationView view, IUserService service) : base(controller, view)
		{
			_service = service;

			View.LoadUsers += LoadUsersAsync;
		}

		public async void LoadUsersAsync()
		{
			View.ChangeStatus(@"Идет загрузка базы данных пользователей...");

			await Task.Run(() => _service.LoadUsers());

			View.Close();
		}
	}
}
