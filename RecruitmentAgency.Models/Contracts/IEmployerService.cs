using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentAgency.Models.Contracts
{
    public interface IEmployerService
    {
        Task DeleteEmployer(EmployerModel employer);
        IEnumerable<EmployerModel> GetAllEmployers();
    }
}