using A.Models;
using A.Models.VM;

namespace A.Repo.RepoInterface
{
    public interface IDriver
    {
        public List<Driver> GetAll();
        public Driver GetDriverById(int id);
        public void Add(DeiverVM deiverVM);
    }
}
