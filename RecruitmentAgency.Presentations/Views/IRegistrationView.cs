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
        CandidateModel NewCandidateInfo { get; }
        EmployerModel NewEmployerInfo { get; }
        public string[] Agencies { set; }

        event Func<Task> Register;
        public bool Mode { get; set; }

        void ShowMessage(string message);
    }
}