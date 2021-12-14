using RecruitmentAgency.Presentations.Common;
using System;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Views
{
    public interface ILoginView : IView
    {
        string Password { get; set; }
        string Username { get; set; }

        event Func<Task> Login;
        event Action Register;

        void ShowMessage(string message);
    }
}