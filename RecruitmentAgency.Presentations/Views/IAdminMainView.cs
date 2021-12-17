using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Views
{
	public interface IAdminMainView : IView
	{
		Action AddVacancy { get; set; }
		Action<VacancyModel> EditVacancy { get; set; }
		Action<VacancyModel> ShowCandidates { get; set; }
		Func<VacancyModel, Task> DeleteVacancy { get; set; }
		Func<EmployerModel, Task> DeleteEmployer { get; set; }

		IEnumerable<VacancyModel> Vacancies { set; }
		IEnumerable<EmployerModel> Employers { set; }
	}
}
