using System;
using System.Collections.Generic;

namespace RecruitmentAgency.DAL.Entities
{
    public class CandidateEntity
    {
        public int Id { get; set; }
        public string Initials { get; set; }
        public DateTime DateOfBorn { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public ICollection<AgencyCandidateEntity> AgencyCandidates { get; set; } = new List<AgencyCandidateEntity>();
    }
}
