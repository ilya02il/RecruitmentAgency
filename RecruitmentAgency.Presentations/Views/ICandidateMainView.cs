using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Common;
using System;
using System.Collections.Generic;

namespace RecruitmentAgency.Presentations.Views
{
    public interface ICandidateMainView : IView
    {
        IEnumerable<VacancyModel> Vacancies { set; }

        event Action<VacancyModel> RespondToVacancy;
    }
}