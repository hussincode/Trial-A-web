using A.Models;
using A.Models.VM;
using A.Repo.RepoInterface;
using Microsoft.AspNetCore.Mvc;

namespace A.Controllers
{
    public class RideController : Controller
    {
        public readonly IRide _ride;
        public readonly IUser _user;
        public readonly IVehicle _vehicle;
        public readonly IDriver _driver;
        public RideController (IRide ride, IUser user, IVehicle vehicle, IDriver driver)
        {
            _ride = ride;
            _user = user;
            _vehicle = vehicle;
            _driver = driver;
        }
        public IActionResult Index()
        {
            var data = _ride.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var data = _ride.GetAll();
            return View(data);
        }
        
        [HttpPost]
        public IActionResult Create(RideVM rideVM)
        {
            var data = new RideVM
            {
                Date = rideVM.Date,
                DropOff = rideVM.DropOff,
                Status = rideVM.Status,
                Fare = rideVM.Fare,
                PickUp = rideVM.PickUp,
                VehicleId = rideVM.VehicleId,
                RideId = rideVM.RideId,
                DriverId = rideVM.DriverId,
                UserId = rideVM.UserId,

            };
            _ride.Add(data);
            return RedirectToAction("Index");
        }
    }
}
