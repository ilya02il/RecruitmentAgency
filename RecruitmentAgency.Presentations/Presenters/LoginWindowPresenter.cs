using RecruitmentAgency.Models;
using RecruitmentAgency.Models.Contracts;
using RecruitmentAgency.Models.Implementations;
using RecruitmentAgency.Presentations.Common;
using RecruitmentAgency.Presentations.Views;
using System;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Presenters
{
    public class LoginWindowPresenter : BasePresenter<ILoginView>
    {
        private readonly IUserService _userService;
        public LoginWindowPresenter(IUserService userService, IApplicationController controller, ILoginView view) : base(controller, view)
        {
            _userService = userService;

            Controller.Run<InitializationWindowPresenter>();

            View.Login += Authenticate;
            View.Register += Register;
        }

        private async Task Authenticate()
        {
            try
            {
                var user = new UserModel
                {
                    Login = View.Username,
                    Password = View.Password
                };

                user = await _userService.Authenticate(user);

                switch (user.RoleId)
                {
                    case Roles.Admin:
                        Controller.Run<AdminMainWindowPresenter>();
                        break;
                    case Roles.Employer:
                        var employer = await _userService.GetEmployerInfo(user);

                        Controller.Run<EmployerMainWindowPresenter, EmployerModel>(employer);
                        break;
                    case Roles.Candidate:

                        var candidate = await _userService.GetCandidateInfo(user);

                        Controller.Run<CandidateMainWindowPresenter, CandidateModel>(candidate);
                        break;
                }

                View.Close();
            }
            catch(Exception exp)
            {
                if (exp.Message == "Login or password is not valid.")
                {
                    View.ShowMessage("Неверный логин или пароль.");
                    View.Username = string.Empty;
                    View.Password = string.Empty;
                }
            }
        }

        private void Register()
        {
            Controller.Run<RegistrationWindowPresenter, string>();
        }
    }
}
