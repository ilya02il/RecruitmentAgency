namespace RecruitmentAgency.Models
{
	public record VacancyModel
	{
		public int Id { get; set; }
		public string Position { get; set; }
		public int Salary { get; set; }
		public string EmployerName { get; set; }
	}
}
