using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Views
{
    public interface IRegistrationView : IView
    {
        UserModel NewUser { get; }
        public string[] Agencies { set; }

        event Func<Task> Register;

        void ShowMessage(string message);
    }
}