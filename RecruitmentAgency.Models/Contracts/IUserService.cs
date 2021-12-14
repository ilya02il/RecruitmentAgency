using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentAgency.Models.Contracts
{
    public interface IUserService
    {
        Task<UserModel> Authenticate(UserModel user);
        Task<int> Register(UserModel newUser);
        Task UpdateUserInfo(UserModel user);
        Task DeleteUser(UserModel user);
        IEnumerable<UserModel> LoadUsers();
    }
}