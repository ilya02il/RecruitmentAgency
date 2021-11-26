using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Views
{
    public interface IAddVacancyView : IView
    {
        Func<Task> AddVacancy { get; set; }
        IEnumerable<string> AgenciesNames { set; }
        VacancyModel NewVacancy { get; }
    }
}