using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public int UserGroupId { get; set;}

        [Required]
        public int UserStateId{ get; set; }
    }
}
