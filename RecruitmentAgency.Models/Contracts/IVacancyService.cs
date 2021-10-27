using System.Collections.Generic;

namespace RecruitmentAgency.Models.Contracts
{
	public interface IVacancyService
	{
		IEnumerable<VacancyModel> GetAllVacancies();
	}
}