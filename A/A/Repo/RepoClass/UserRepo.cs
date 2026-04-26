using A.Models;
using A.Repo.RepoInterface;

namespace A.Repo.RepoClass
{
    public class UserRepo : IUser
    {
        public readonly UberContext _uberContext;
        public UserRepo(UberContext context)
        {
            _uberContext = context;
        }

        public List<User> GetAll()
        {
           return _uberContext.users.ToList();
        }

        public User GetById(int id)
        {
            var data = _uberContext.users.FirstOrDefault(o => o.UserId == id);
            return data;
        }

        public void Add(User user)
        {
          
            _uberContext.users.Add(user);
            _uberContext.SaveChanges();
        }

        public void Update(User user)
        {
            var data = new User
            {
                UserName = user.UserName,
                Email = user.Email,
                Password =  user.Password,
                Role = user.Role,
                phone = user.phone
            };
            _uberContext.users.Update(data);
            _uberContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var data = _uberContext.users.Find(id);
            if(data != null)
            {
                _uberContext.users.Remove(data);
                _uberContext.SaveChanges();
            }
        }

        public List<User> SearchByEmail(string email)
        {
            var t = _uberContext.users.AsQueryable();
            if (!string.IsNullOrEmpty(email))
            {
                t = t.Where(o => o.Email.Contains(email));
            }
            return t.ToList();
        }
    }
}
