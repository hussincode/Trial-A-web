using A.Models;

namespace A.Repo.RepoInterface
{
    public interface IUser
    {
        public List<User> GetAll();
        public User GetById(int id);
        public void Add(User user);
        public void Update(User user);
        public void Delete(int id);
        public List<User> SearchByEmail(string email);
    }
}
