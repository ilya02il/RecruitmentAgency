﻿namespace RecruitmentAgency.Models
{
	public class UserModel
	{
		public int Id { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

		public int RoleId { get; set; }
		public RoleModel Role { get; set; }
	}
}
