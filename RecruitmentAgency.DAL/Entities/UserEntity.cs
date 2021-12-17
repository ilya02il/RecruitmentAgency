using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.DAL.Entities
{
	public class UserEntity : IEntity
	{
		public int Id { get; set; }
		[Required]
		public string Login { get; set; }
		[Required]
		public string Password { get; set; }

        public CandidateInfoEntity CandidateInfo { get; set; }
        public EmployerInfoEntity EmployerInfo { get; set; }

        [Required]
		public int RoleId { get; set; }
		[Required]
		public RoleEntity Role { get; set; }
	}
}
