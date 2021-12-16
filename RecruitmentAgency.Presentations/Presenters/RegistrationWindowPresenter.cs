using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;
using System;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class RegistrationWindowPresenter : BasePresenter<IRegistrationView, string>
    {
        private readonly IUserService _userService;

        public RegistrationWindowPresenter(IUserService userService, IApplicationController controller, IRegistrationView view) : base(controller, view)
        {
            _userService = userService;

            View.Register += Register;
        }

        public override void Run(params string[] arguments)
        {
            View.Agencies = arguments;
            View.Show();
        }

        public override void Run(string argument)
        {
            View.Agencies = new string[] { argument };
            View.Show();
        }

        private async Task Register()
        {
            try
            {
                await _userService.Register(View.NewUser);

                View.Close();
            }
            catch(Exception exp)
            {
                View.ShowMessage(exp.Message);
            }
        }
    }
}
