namespace RecruitmentAgency.DAL.Entities
{
    public class VacancyEntity : IEntity
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public int AgencyId { get; set; }
        public AgencyEntity Agency { get; set; }
    }
}
