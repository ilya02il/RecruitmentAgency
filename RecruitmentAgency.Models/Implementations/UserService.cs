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

        private int Register(UserModel newUser)
        {
            var user = _dbRepository.GetAll<UserEntity>()
                .FirstOrDefault(u => u.Login == newUser.Login);

            if (user != null)
                throw new Exception("User with this login already exist.");

            var entity = _mapper.Map<UserEntity>(newUser);

            _dbRepository.Add(entity);
            _dbRepository.SaveChanges();

            var result = entity.Id;

            return result;
        }

        public async Task RegisterCandidate(UserModel userInfo, CandidateModel candidateInfo)
        {
            var result = Register(userInfo);

            var candidateEntity = _mapper.Map<CandidateInfoEntity>(candidateInfo);
            candidateEntity.UserId = result;

            _dbRepository.Add(candidateEntity);
            await _dbRepository.SaveChangesAsync();
        }

        public async Task RegisterEmployer(UserModel userInfo, EmployerModel employerInfo)
        {
            var result = Register(userInfo);

            var employerEntity = _mapper.Map<EmployerInfoEntity>(employerInfo);
            employerEntity.UserId = result;

            _dbRepository.Add(employerEntity);
            await _dbRepository.SaveChangesAsync();
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

        public async Task<EmployerModel> GetEmployerInfo(UserModel user)
        {
            var employerInfoEntity = await _dbRepository.GetAll<EmployerInfoEntity>()
                .FirstAsync(e => e.UserId == user.Id);

            return _mapper.Map<EmployerModel>(employerInfoEntity);
        }

        public async Task<CandidateModel> GetCandidateInfo(UserModel user)
        {
            var candidateInfoEntity = await _dbRepository.GetAll<CandidateInfoEntity>()
                .FirstAsync(e => e.UserId == user.Id);

            return _mapper.Map<CandidateModel>(candidateInfoEntity);
        }
    }
}
