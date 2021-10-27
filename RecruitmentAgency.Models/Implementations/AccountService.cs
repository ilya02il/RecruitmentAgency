using AutoMapper;
using RecruitmentAgency.DAL.Contracts;
using RecruitmentAgency.DAL.Entities;
using RecruitmentAgency.Models.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentAgency.Models.Implementations
{
	public class AccountService : IAccountService
	{
		private readonly IDbRepository _dbRepository;
		private readonly IMapper _mapper;

		public AccountService(IDbRepository dbRepository, IMapper mapper)
		{
			_dbRepository = dbRepository;
			_mapper = mapper;
		}

		public UserModel Authenticate(UserModel user)
		{
			var userFromDb = _dbRepository.GetAll<UserEntity>().
				FirstOrDefault(u => u.Login == user.Login && u.Password == user.Password);

			if (userFromDb == null)
				return null;

			return _mapper.Map<UserModel>(userFromDb);
		}

		public async Task<int> Register(UserModel newUser)
		{
			var userEntity = _mapper.Map<UserEntity>(newUser);

			var result = await _dbRepository.Add(userEntity);
			await _dbRepository.SaveChangesAsync();

			return result;
		}
	}
}
