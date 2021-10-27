namespace RecruitmentAgency.DAL.Entities
{
    public class AgencyCandidateEntity : IEntity
    {
        public int Id { get; set; }

        public int AgencyId { get; set; }
        public AgencyEntity Agency { get; set; }

        public int CandidateId { get; set; }
        public CandidateEntity Candidate { get; set; }
    }
}
