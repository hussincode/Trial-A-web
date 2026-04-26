using System.ComponentModel.DataAnnotations;

namespace A.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [Range(8, int.MaxValue)]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        public string phone {  get; set; }
        [Required]
        public string Role { get; set; }
        public List<Driver> drivers { get; set; }
        public List<Vehicle_Type> vehicles {  get; set; }
        public List<Ride> rides { get; set; }


    }
}
