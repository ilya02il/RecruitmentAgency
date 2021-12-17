using System.ComponentModel.DataAnnotations;

namespace RecruitmentAgency.DAL.Entities
{
    public class EmployerInfoEntity : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public int UserId { get; set; }
        [Required]
        public UserEntity User { get; set; }
    }
}
