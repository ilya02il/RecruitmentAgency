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
			var entities = _dbRepository.GetAll<VacancyEntity>();

			if (entities == null)
				throw new NullReferenceException();

			return entities.Select(e => _mapper.Map<VacancyModel>(e));
		}

		public async Task<int> AddVacancy(VacancyModel newVacancy)
		{
			var entity = _mapper.Map<VacancyEntity>(newVacancy);

			var employer = await _dbRepository.Get<EmployerInfoEntity>(e => e.Name == newVacancy.EmployerName)
				.FirstAsync();

			entity.EmployerId = employer.Id;
			entity.Employer = null;

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
			var entity = await _dbRepository.GetAll<VacancyEntity>()
				.Include(v => v.Employer)
				.FirstAsync(predicate);

			await _dbRepository.Remove(entity);
			await _dbRepository.SaveChangesAsync();
		}

		public async Task UpdateVacancyInfo(VacancyModel vacancy)
		{
			//var innerEntity = _dbRepository.GetAll<VacancyEntity>().FirstAsync(v => v.Position && v.Salary)
			var entity = _mapper.Map<VacancyEntity>(vacancy);

			var employer = await _dbRepository.Get<EmployerInfoEntity>(e => e.Name == vacancy.EmployerName)
				.FirstAsync();

			entity.EmployerId = employer.Id;
			entity.Employer = null;

			await _dbRepository.Update(entity);
			await _dbRepository.SaveChangesAsync();
		}

		public IEnumerable<CandidateModel> GetVacancyCandidates(VacancyModel vacancy)
        {
			var vacancyCandidates = _dbRepository.GetAll<VacancyCandidatesEntity>()
				.Include(vc => vc.Candidate)
				.Where(vc => vc.VacancyId == vacancy.Id);

			return vacancyCandidates.Select(vc => new CandidateModel
			{
				Initials = vc.Candidate.Initials,
				DateOfBirth = vc.Candidate.DateOfBorn,
				Position = vacancy.Position,
				Salary = vacancy.Salary
			});
        }

		public async Task AppendCandidate(CandidateModel candidate)
        {
			var candidateEntity = await _dbRepository.GetAll<CandidateInfoEntity>()
				.FirstAsync(c => c.Initials == candidate.Initials && c.DateOfBorn == candidate.DateOfBirth);

			var vacancyEntity = await _dbRepository.GetAll<VacancyEntity>()
				.FirstAsync(v => v.Position == candidate.Position && v.Salary == candidate.Salary);

            var vacancyCandidate = new VacancyCandidatesEntity
            {
				CandidateId = candidateEntity.Id,
				VacancyId = candidateEntity.Id
			};

        }
    }
}
