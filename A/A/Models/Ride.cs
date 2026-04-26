using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A.Models
{
    public class Ride
    {
        [Key]
        public int RideId { get; set; }
        [Required]
        public string PickUp { get; set; }
        [Required]
        public string DropOff { get; set; }
        [Required]
        public DateOnly Date {  get; set; }
        [Required]
        [Range(0 , int.MaxValue)]
        public int Fare { get; set; }
        [Required]
        public string Status { get; set; }
        [ForeignKey("DriverId")]
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        [ForeignKey("VehicleId")]
        public int VehicleId { get; set; }
        public Vehicle_Type VehicleType { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
