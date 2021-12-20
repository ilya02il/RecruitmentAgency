using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentAgency.Models.Contracts
{
    public interface IUserService
    {
        Task<UserModel> Authenticate(UserModel user);
        Task RegisterCandidate(UserModel userInfo, CandidateModel candidateInfo);
        Task RegisterEmployer(UserModel userInfo, EmployerModel employerInfo);
        Task UpdateUserInfo(UserModel user);
        Task DeleteUser(UserModel user);
        IEnumerable<UserModel> LoadUsers();
        Task<EmployerModel> GetEmployerInfo(UserModel user);
        Task<CandidateModel> GetCandidateInfo(UserModel user);
    }
}