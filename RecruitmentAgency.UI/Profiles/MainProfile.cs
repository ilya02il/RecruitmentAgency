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
