using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hanover.Models
{
    [Table("RE_Contacts")]
    public class ContactModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

    }
}
