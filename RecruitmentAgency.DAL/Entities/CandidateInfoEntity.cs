using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.DAL.Entities
{
    public class CandidateInfoEntity : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Initials { get; set; }
        [Required]
        public DateTime DateOfBorn { get; set; }

        [Required]
        public int UserId { get; set; }
        [Required]
        public UserEntity User { get; set; }

        public ICollection<VacancyCandidatesEntity> VacancyCandidates { get; set; }
    }
}
