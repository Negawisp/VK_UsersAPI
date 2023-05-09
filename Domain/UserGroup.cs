using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class UserGroup
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        public string? Description { get; set; }
    }
}
