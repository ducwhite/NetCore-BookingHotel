using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }


    }
}
