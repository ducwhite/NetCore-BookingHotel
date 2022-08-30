using System.ComponentModel.DataAnnotations;

namespace Booking.Models
{
    public class District
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="District")]
        public string Name { get; set; }
    }
}
