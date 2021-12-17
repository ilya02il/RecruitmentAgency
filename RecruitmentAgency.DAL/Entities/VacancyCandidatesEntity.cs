using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.DAL.Entities
{
    public class VacancyCandidatesEntity : IEntity
    {
        public int Id { get; set; }

        [Required]
        public int VacancyId { get; set; }
        public VacancyEntity Vacancy { get; set; }

        [Required]
        public int CandidateId { get; set; }
        public CandidateInfoEntity Candidate { get; set; }
    }
}
