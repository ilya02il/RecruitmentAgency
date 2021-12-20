using Microsoft.EntityFrameworkCore;
using RecruitmentAgency.DAL.Contracts;
using RecruitmentAgency.DAL.Entities;
using RecruitmentAgency.Models.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentAgency.Models.Implementations
{
    public class EmployerService : IEmployerService
    {
        private readonly IDbRepository _dbRepository;

        public EmployerService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        public IEnumerable<EmployerModel> GetAllEmployers()
        {
            var employersEntities = _dbRepository.GetAll<EmployerInfoEntity>().ToList();

            var employersModels = new List<EmployerModel>();

            foreach (var employer in employersEntities)
            {
                employersModels.Add(new EmployerModel { Name = employer.Name });
            }

            return employersModels;
        }

        public async Task DeleteEmployer(EmployerModel employer)
        {
            var employerEntity = await _dbRepository.GetAll<EmployerInfoEntity>()
                .FirstAsync(e => e.Name == employer.Name);

            var userEntity = await _dbRepository.GetAll<UserEntity>()
                .FirstAsync(u => u.Id == employerEntity.UserId);

            await _dbRepository.Remove(employerEntity);
            await _dbRepository.Remove(userEntity);
            await _dbRepository.SaveChangesAsync();
        }
    }
}
