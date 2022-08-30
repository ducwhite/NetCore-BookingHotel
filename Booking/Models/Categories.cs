using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class Categories
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Category")]
        public string Name { get; set; }
    }
}
