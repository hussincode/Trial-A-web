using A.Models;
using A.Models.VM;
using A.Repo.RepoInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.Identity.Client;

namespace A.Repo.RepoClass
{
    public class RideRepo : IRide
    {
        public UberContext _UberContext { get; set; }
        public RideRepo(UberContext uberContext)
        {
            _UberContext = uberContext;
        }
        public List<Ride> GetAll()
        {
            var data = _UberContext.rides.Include(o => o.User).Include(o => o.Driver).Include(o => o.VehicleType).ToList();
            return data;
        }

        public Ride GetById(int id)
        {
            var data = _UberContext.rides.FirstOrDefault(o => o.DriverId == id);
            return data;
        }

        public void Add(RideVM rideVM)
        {
            var data = new Ride
            {
                PickUp = rideVM.PickUp,
                DropOff = rideVM.DropOff,
                Date = rideVM.Date,
                Fare = rideVM.Fare,
                DriverId = rideVM.DriverId,
                VehicleId = rideVM.VehicleId,
                UserId = rideVM.UserId,
                Status = rideVM.Status
            };

            _UberContext.rides.Add(data);
            _UberContext.SaveChanges();
        }
    }
}
