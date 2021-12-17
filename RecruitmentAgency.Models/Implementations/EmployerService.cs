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
            var employersEntities = _dbRepository.GetAll<EmployerInfoEntity>();

            return employersEntities.Select(e => new EmployerModel
            {
                Name = e.Name
            });
        }

        public async Task DeleteEmployer(EmployerModel employer)
        {
            var employerEntity = await _dbRepository.GetAll<EmployerInfoEntity>()
                .FirstAsync(e => e.Name == employer.Name);

            await _dbRepository.Remove(employerEntity);
            await _dbRepository.SaveChangesAsync();
        }
    }
}
