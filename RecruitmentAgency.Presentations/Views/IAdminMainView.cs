using RecruitmentAgency.Models;
using RecruitmentAgency.Presentations.Common;
using System;
using System.Collections.Generic;

namespace RecruitmentAgency.Presentations.Views
{
	public interface IAdminMainView : IView
	{
		Action AddAgency { get; set; }

		IEnumerable<AgencyModel> Agencies { set; }
		IEnumerable<VacancyModel> Vacancies { set; }
	}
}
