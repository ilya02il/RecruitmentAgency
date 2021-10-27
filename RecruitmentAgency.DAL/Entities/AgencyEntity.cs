using System.Collections.Generic;

namespace RecruitmentAgency.DAL.Entities
{
    public class AgencyEntity : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<VacancyEntity> Vacancies { get; set; } = new List<VacancyEntity>();
        public ICollection<AgencyCandidateEntity> AgencyCandidates { get; set; } = new List<AgencyCandidateEntity>();
    }
}
