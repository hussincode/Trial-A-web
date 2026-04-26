using A.Models;
using A.Models.VM;

namespace A.Repo.RepoInterface
{
    public interface IRide
    {
        public List<Ride> GetAll();
        public Ride GetById(int id);
        public void Add(RideVM rideVM);

    }
}
