using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A.Models.VM
{
    public class RideVM
    {
        public int RideId { get; set; }
        public string PickUp { get; set; }
        public string DropOff { get; set; }
        public DateOnly Date { get; set; }
        public int Fare { get; set; }
        public string Status { get; set; }
        public int DriverId { get; set; }
        public List<Driver> drivers { get; set; }
        public int VehicleId { get; set; }
        public List<Vehicle_Type> vehicles { get; set; }
        public int UserId { get; set; }
        public List<User> users { get; set; }
    }
}
