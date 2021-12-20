using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitmentAgency.DAL.Entities
{
    public class EmployerInfoEntity : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
