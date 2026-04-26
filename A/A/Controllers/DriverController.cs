using A.Models;
using A.Models.VM;
using A.Repo.RepoInterface;
using Microsoft.AspNetCore.Mvc;

namespace A.Controllers
{
    public class DriverController : Controller
    {
        public readonly IDriver _driver;
        public readonly IUser _User;
        public DriverController(IDriver driver, IUser user)
        {
            _driver = driver;
            _User = user;
        }

        public IActionResult Index()
        {
            var data = _driver.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var data = _driver.GetAll();
            return View(data);
        }

        [HttpPost]
        public IActionResult Create(DeiverVM deiverVM)
        {
            var data = new DeiverVM
            {
                Name = deiverVM.Name,
                Phone = deiverVM.Phone,
                username = deiverVM.username,
                Status = deiverVM.Status,
                LicenseNumber = deiverVM.LicenseNumber,
            };
             _driver.Add(data);
            return RedirectToAction("Index");
        }


    }
}
