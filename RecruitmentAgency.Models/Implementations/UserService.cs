using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecruitmentAgency.DAL.Contracts;
using RecruitmentAgency.DAL.Entities;
using RecruitmentAgency.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentAgency.Models.Implementations
{
    public class UserService : IUserService
    {
        private readonly IDbRepository _dbRepository;
        private readonly IMapper _mapper;

        public UserService(IDbRepository dbRepository, IMapper mapper)
        {
            _dbRepository = dbRepository;
            _mapper = mapper;
        }

        public async Task<UserModel> Authenticate(UserModel user)
        {
            var entity = await _dbRepository.GetAll<UserEntity>().FirstOrDefaultAsync(u => u.Login == user.Login && u.Password == user.Password);

            if (entity == null)
                throw new Exception("Login or password is not valid.");

            var model = _mapper.Map<UserModel>(entity);

            return model;
        }

        public async Task<int> Register(UserModel newUser)
        {
            var entity = _mapper.Map<UserEntity>(newUser);

            var result = await _dbRepository.Add(entity);

            if (result == 0)
                throw new Exception("User wasn't added.");

            await _dbRepository.SaveChangesAsync();

            return result;
        }

        public async Task UpdateUserInfo(UserModel user)
        {
            var entity = _mapper.Map<UserEntity>(user);

            await _dbRepository.Update(entity);
            await _dbRepository.SaveChangesAsync();
        }

        public async Task DeleteUser(UserModel user)
        {
            var entity = _mapper.Map<UserEntity>(user);

            await _dbRepository.Remove(entity);
            await _dbRepository.SaveChangesAsync();
        }

        public IEnumerable<UserModel> LoadUsers()
        {
            var usersEntities = _dbRepository.GetAll<UserEntity>();

            return usersEntities.Select(e => _mapper.Map<UserModel>(e));
        }
    }
}
