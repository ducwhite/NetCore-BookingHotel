using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Booking.Models
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Room's name")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Area { get; set; }
        public string Image { get; set; }
        [Required]
        public string Address { get; set; }
        [Display(Name="Phone Number")]
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name="Bed's Name")]
        public string Bed { get; set; }
        [Required]
        public string Services { get; set; }
        [Display(Name="Guest Quantity")]
        public int GuestQuantity { get; set; }
        [Display(Name = "Bed Quantity")]
        public int BedQuantity { get; set; }
        [Required]
        public string Description { get; set; }
        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }
        [Required]
        [Display(Name="Map Embed")]
        public string MapEmbed { get; set; }

        [Display(Name="Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")] 
        public Categories Categories { get; set; }

        [Display(Name = "District")]
        public int DistrictId { get; set; }
        [ForeignKey("DistrictId")]
        public District District { get; set; }

    }
}
