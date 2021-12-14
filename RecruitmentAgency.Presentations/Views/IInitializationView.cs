using RecruitmentAgency.Presentations.Common;
using System;

namespace RecruitmentAgency.Presentations.Views
{
    public interface IInitializationView : IView
    {
        Action LoadUsers { get; set; }

        void ChangeStatus(string status);
    }
}