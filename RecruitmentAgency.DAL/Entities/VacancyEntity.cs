using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.DAL.Entities
{
    public class VacancyEntity : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public int Salary { get; set; }

        [Required]
        public int EmployerId { get; set; }
        [Required]
        public EmployerInfoEntity Employer { get; set; }

        public ICollection<VacancyCandidatesEntity> VacancyCandidates { get; set; }
    }
}
