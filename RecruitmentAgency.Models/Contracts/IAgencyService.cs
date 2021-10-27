using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentAgency.Models.Contracts
{
	public interface IAgencyService
	{
		Task<int> AddAgency(AgencyModel newAgency);
		Task DeleteAgency(AgencyModel agency);
		IEnumerable<AgencyModel> GetAllAgencies();
		Task UpdateAgencyInfo(AgencyModel agency);
	}
}