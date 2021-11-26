using RecruitmentAgency.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RecruitmentAgency.Models.Contracts
{
	public interface IVacancyService
	{
		IEnumerable<VacancyModel> GetAllVacancies();
		Task<int> AddVacancy(VacancyModel newVacancy);
		Task DeleteVacancy(VacancyModel vacancy);
		Task DeleteVacancy(Expression<Func<VacancyEntity, bool>> predicate);
		Task UpdateVacancyInfo(VacancyModel vacancy);
	}
}