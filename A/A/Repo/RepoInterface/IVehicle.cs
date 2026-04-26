using A.Models;
using A.Models.VM;

namespace A.Repo.RepoInterface
{
    public interface IVehicle
    {
        public List<Vehicle_Type> GetAll();
        public Vehicle_Type GetById(int id);
        public void Add(VehicleVM vehicle);
    }
}
