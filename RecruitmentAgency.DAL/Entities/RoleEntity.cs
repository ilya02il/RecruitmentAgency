using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.DAL.Entities
{
	public class RoleEntity : IEntity
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }

		public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>();
	}
}
