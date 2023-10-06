using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Test
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Givenname { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
