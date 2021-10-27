using System.Threading.Tasks;

namespace RecruitmentAgency.Models.Contracts
{
	public interface IAccountService
	{
		UserModel Authenticate(UserModel user);
		Task<int> Register(UserModel newUser);
	}
}