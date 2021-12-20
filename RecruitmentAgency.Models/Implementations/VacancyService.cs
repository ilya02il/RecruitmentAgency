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
			var entities = _dbRepository.GetAll<VacancyEntity>()
				.Include(v => v.Employer);

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

			_dbRepository.Add(entity);
			await _dbRepository.SaveChangesAsync();

			return 1;
		}

		public async Task DeleteVacancy(VacancyModel vacancy)
		{
			var entity = await _dbRepository.GetAll<VacancyEntity>()
				.Include(v => v.Employer)
				.FirstOrDefaultAsync(v => v.Position == vacancy.Position &&
				v.Salary == vacancy.Salary &&
				v.Employer.Name == vacancy.EmployerName);

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
			var vacancyEntity = _dbRepository.GetAll<VacancyEntity>()
				.Include(v => v.Employer)
				.First(v => v.Employer.Name == vacancy.EmployerName &&
					v.Position == vacancy.Position &&
					v.Salary == vacancy.Salary);

			var vacancyCandidates = _dbRepository.GetAll<VacancyCandidatesEntity>()
				.Include(vc => vc.Candidate)
				.Where(vc => vc.VacancyId == vacancyEntity.Id)
				.ToList();

			return vacancyCandidates.Select(vc => new CandidateModel
			{
				Initials = vc.Candidate.Initials,
				DateOfBirth = vc.Candidate.DateOfBirth,
				Position = vacancy.Position,
				Salary = vacancy.Salary
			});
        }

		public async Task AppendCandidate(VacancyModel vacancy, CandidateModel candidate)
        {
			var candidateEntity = await _dbRepository.GetAll<CandidateInfoEntity>()
				.FirstAsync(c => c.Initials == candidate.Initials && c.DateOfBirth == candidate.DateOfBirth);

			var vacancyEntity = await _dbRepository.GetAll<VacancyEntity>()
				.FirstAsync(v => v.Position == vacancy.Position && v.Salary == vacancy.Salary);

            var vacancyCandidate = new VacancyCandidatesEntity
            {
				CandidateId = candidateEntity.Id,
				VacancyId = vacancyEntity.Id
			};

			_dbRepository.Add(vacancyCandidate);
			await _dbRepository.SaveChangesAsync();
        }
    }
}
