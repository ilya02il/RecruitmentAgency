using System;

namespace RecruitmentAgency.Models
{
    public record CandidateModel
    {
        public string Initials { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
    }
}
