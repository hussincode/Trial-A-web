using A.Models;
using A.Models.VM;
using A.Repo.RepoInterface;
using Microsoft.EntityFrameworkCore;

namespace A.Repo.RepoClass
{
    public class VehicleRepo : IVehicle
    {
        public readonly UberContext _Ubercontext;
        public VehicleRepo(UberContext ubercontext)
        {
            _Ubercontext = ubercontext;
        }

        public List<Vehicle_Type> GetAll()
        {
            var data = _Ubercontext.vehicle_Types.Include(o =>o .User).ToList();
            return data;
        }

        public Vehicle_Type GetById(int id)
        {
            var data = _Ubercontext.vehicle_Types.FirstOrDefault(o => o.VehicleId == id);
            return data;
        }

        public void Add(VehicleVM vehicle)
        {
            var data = new Vehicle_Type
            {
                Name = vehicle.Name,
                BaseFare = vehicle.BaseFare,
                UserId = vehicle.UserId,
            };
            _Ubercontext.vehicle_Types.Add(data);
            _Ubercontext.SaveChanges();
        }
    }
}
