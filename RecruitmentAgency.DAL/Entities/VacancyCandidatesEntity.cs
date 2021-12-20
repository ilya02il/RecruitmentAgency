using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitmentAgency.DAL.Entities
{
    public class VacancyCandidatesEntity : IEntity
    {
        [NotMapped]
        public int Id { get; set; }

        public int VacancyId { get; set; }
        public VacancyEntity Vacancy { get; set; }

        public int CandidateId { get; set; }
        public CandidateInfoEntity Candidate { get; set; }
    }
}
