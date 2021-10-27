using AutoMapper;
using RecruitmentAgency.DAL.Contracts;
using RecruitmentAgency.DAL.Entities;
using RecruitmentAgency.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentAgency.Models.Implementations
{
	public class AgencyService : IAgencyService
	{
		private readonly IDbRepository _dbRepository;
		private readonly IMapper _mapper;

		public AgencyService(IDbRepository dbRepository, IMapper mapper)
		{
			_dbRepository = dbRepository;
			_mapper = mapper;
		}

		public IEnumerable<AgencyModel> GetAllAgencies()
		{
			var entities = _dbRepository.GetAll<AgencyEntity>();

			if (entities == null)
				throw new NullReferenceException();

			return entities.Select(e => _mapper.Map<AgencyModel>(e));
		}

		public async Task<int> AddAgency(AgencyModel newAgency)
		{
			var entity = _mapper.Map<AgencyEntity>(newAgency);

			var result = await _dbRepository.Add(entity);
			await _dbRepository.SaveChangesAsync();

			return result;
		}

		public async Task DeleteAgency(AgencyModel agency)
		{
			var entity = _mapper.Map<AgencyEntity>(agency);

			await _dbRepository.Remove(entity);
		}

		public async Task UpdateAgencyInfo(AgencyModel agency)
		{
			var entity = _mapper.Map<AgencyEntity>(agency);

			await _dbRepository.Update(entity);
		}
	}
}
