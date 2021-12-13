using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentAgency.Presentations.Views
{
	public interface IAdminMainView : IView
	{
		Action AddAgency { get; set; }
		Action<AgencyModel> EditAgency { get; set; }
		Func<AgencyModel, Task> DeleteAgency { get; set; }
		Action AddVacancy { get; set; }
		Action<VacancyModel> EditVacancy { get; set; }
		Func<VacancyModel, Task> DeleteVacancy { get; set; }

		IEnumerable<AgencyModel> Agencies { set; }
		IEnumerable<VacancyModel> Vacancies { set; }
	}
}
