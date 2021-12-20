using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Views
{
    public interface IEmployerMainView : IView
    {
        Action AddVacancy { get; set; }
        Func<VacancyModel, Task> DeleteVacancy { get; set; }
        Action<VacancyModel> EditVacancy { get; set; }
        IEnumerable<VacancyModel> Vacancies { set; }
        EmployerModel CurrentEmployer { get; set; }
        Action<VacancyModel> ShowCandidates { get; set; }
    }
}