using A.Models;
using A.Repo.RepoInterface;
using Microsoft.AspNetCore.Mvc;

namespace A.Controllers
{
    public class UserController : Controller
    {
        public readonly IUser _User;
        public UserController(IUser user)
        {
            _User = user;
        }
        public IActionResult Index()
        {
            var data = _User.GetAll();
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            
             _User.Add(user);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var data = _User.GetById(id);
            if(data == null)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            _User.Update(user);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(User user)
        {
            
            _User.Delete(user.UserId);
            return RedirectToAction("Index");
        }

        public IActionResult Search(string Email)
        {
            _User.SearchByEmail(Email);
            return RedirectToAction("Index", Email);
        }
    }
}
