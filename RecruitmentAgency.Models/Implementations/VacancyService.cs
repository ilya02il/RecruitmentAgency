using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecruitmentAgency.DAL.Contracts;
using RecruitmentAgency.DAL.Entities;
using RecruitmentAgency.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

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
	}
}
