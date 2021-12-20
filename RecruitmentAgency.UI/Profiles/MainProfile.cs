using AutoMapper;
using RecruitmentAgency.DAL.Entities;
using RecruitmentAgency.Models;

namespace RecruitmentAgency.UI.Profiles
{
	public class MainProfile : Profile
	{
		public MainProfile()
		{
			CreateMap<UserEntity, UserModel>();
			CreateMap<UserModel, UserEntity>();

			CreateMap<CandidateModel, CandidateInfoEntity>();
			CreateMap<CandidateInfoEntity, CandidateModel>();

			CreateMap<EmployerInfoEntity, EmployerModel>();
			CreateMap<EmployerModel, EmployerInfoEntity>();

			CreateMap<VacancyEntity, VacancyModel>()
				.ForPath(dest => dest.EmployerName,
				opt => opt.MapFrom(src => src.Employer.Name));
			CreateMap<VacancyModel, VacancyEntity>()
				.ForPath(dest => dest.Employer.Name,
				opt => opt.MapFrom(src => src.EmployerName));

			//CreateMap<AgencyEntity, AgencyModel>();
			//CreateMap<AgencyModel, AgencyEntity>();

			//CreateMap<VacancyEntity, VacancyModel>()
			//	.ForPath(dest => dest.AgencyName,
			//		opt => opt.MapFrom(src => src.Agency.Name));
			//CreateMap<VacancyModel, VacancyEntity>()
			//	.ForPath(dest => dest.Agency.Name,
			//		opt => opt.MapFrom(src => src.AgencyName));
		}
	}
}
