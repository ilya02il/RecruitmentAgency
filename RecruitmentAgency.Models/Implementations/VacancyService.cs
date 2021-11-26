using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecruitmentAgency.DAL.Contracts;
using RecruitmentAgency.DAL.Entities;
using RecruitmentAgency.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RecruitmentAgency.Models.Implementations
{
	public class VacancyService : IVacancyService
	{
		private readonly IDbRepository _dbRepository;
		private readonly IMapper _mapper;

		public VacancyService(IDbRepository dbRepository, IMapper mapper)
		{
			_dbRepository = dbRepository;
			_mapper = mapper;
		}

		public IEnumerable<VacancyModel> GetAllVacancies()
		{
			var entities = _dbRepository.GetAll<VacancyEntity>().Include(v => v.Agency);

			if (entities == null)
				throw new NullReferenceException();

			return entities.Select(e => _mapper.Map<VacancyModel>(e));
		}

		public async Task<int> AddVacancy(VacancyModel newVacancy)
		{
			var entity = _mapper.Map<VacancyEntity>(newVacancy);

			var agency = await _dbRepository.Get<AgencyEntity>(a => a.Name == entity.Agency.Name).FirstAsync();

			entity.AgencyId = agency.Id;
			entity.Agency = null;

			var result = await _dbRepository.Add(entity);
			await _dbRepository.SaveChangesAsync();

			return result;
		}

		public async Task DeleteVacancy(VacancyModel vacancy)
		{
			var entity = _mapper.Map<VacancyEntity>(vacancy);

			await _dbRepository.Remove(entity);
			await _dbRepository.SaveChangesAsync();
		}

		public async Task DeleteVacancy(Expression<Func<VacancyEntity, bool>> predicate)
		{
			var entity = await _dbRepository.GetAll<VacancyEntity>().Include(v => v.Agency).FirstAsync(predicate);

			await _dbRepository.Remove(entity);
			await _dbRepository.SaveChangesAsync();
		}

		public async Task UpdateVacancyInfo(VacancyModel vacancy)
		{
			var entity = _mapper.Map<VacancyEntity>(vacancy);

			var agency = await _dbRepository.Get<AgencyEntity>(a => a.Name == entity.Agency.Name).FirstAsync();

			entity.AgencyId = agency.Id;
			entity.Agency = null;

			await _dbRepository.Update(entity);
			await _dbRepository.SaveChangesAsync();
		}
	}
}
