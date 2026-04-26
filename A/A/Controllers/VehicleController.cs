using A.Models.VM;
using A.Repo.RepoInterface;
using Microsoft.AspNetCore.Mvc;

namespace A.Controllers
{
    public class VehicleController : Controller
    {
        public readonly IVehicle _vehicle;
        public readonly IUser _user;
        public VehicleController(IVehicle vehicle, IUser user)
        {
            _vehicle = vehicle;
            _user = user;
        }

        public IActionResult Index()
        {
            var data = _vehicle.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(VehicleVM vehicle)
        {
            var data = new VehicleVM
            {
                BaseFare = vehicle.BaseFare,
                Name = vehicle.Name,
                UserId = vehicle.UserId,
                VehicleId = vehicle.VehicleId,
                
            };
            _vehicle.Add(data);
            return RedirectToAction("Index");
        }
    }
}
