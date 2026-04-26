using A.Models;
using A.Models.VM;
using A.Repo.RepoInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace A.Repo.RepoClass
{
    public class DriverRepo : IDriver
    {
        public readonly UberContext _uberContext;
        public DriverRepo(UberContext context)
        {
            _uberContext = context;
        }

        public List<Driver> GetAll()
        {
            var data = _uberContext.drivers.Include(o => o.User).ToList();
            return data;
        }

        public Driver GetDriverById(int id)
        {
            var data = _uberContext.drivers.FirstOrDefault(o => o.DriverId == id);
            return data;
        }

        public void Add(DeiverVM driver)
        {
            var data = new Driver
            {
                Name = driver.Name,
                LicenseNumber = driver.LicenseNumber,
                Phone = driver.Phone,
                Status = driver.Status,
                
            };
            _uberContext.drivers.Add(data);
            _uberContext.SaveChanges();
            
        }

    }
}
