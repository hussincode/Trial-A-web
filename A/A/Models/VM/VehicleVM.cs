using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A.Models.VM
{
    public class VehicleVM
    {
        public int VehicleId { get; set; }
        public string Name { get; set; }
        public int BaseFare { get; set; }
        public int UserId { get; set; }
        public List<User> users { get; set; }
    }
}
