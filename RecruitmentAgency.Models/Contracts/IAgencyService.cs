using RecruitmentAgency.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RecruitmentAgency.Models.Contracts
{
    public interface IAgencyService
	{
		Task<int> AddAgency(AgencyModel newAgency);
		Task DeleteAgency(AgencyModel agency);
		Task DeleteAgency(Expression<Func<AgencyEntity, bool>> predicate);
		IEnumerable<AgencyModel> GetAllAgencies();
		Task UpdateAgencyInfo(AgencyModel agency);
	}
}