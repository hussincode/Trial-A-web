using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A.Models.VM
{
    public class DeiverVM
    {

        public int DriverId { get; set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public string username { get; set; }
       public List<User> users { get; set; }
    }
}
