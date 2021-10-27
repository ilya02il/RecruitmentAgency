namespace RecruitmentAgency.DAL.Entities
{
	public class UserEntity : IEntity
	{
		public int Id { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

		public int RoleId { get; set; }
		public RoleEntity Role { get; set; }
	}
}
