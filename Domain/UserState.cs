using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class UserState
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        public string? Description { get; set; }
    }
}
