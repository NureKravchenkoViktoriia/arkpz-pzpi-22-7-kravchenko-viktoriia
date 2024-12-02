using System.Collections.Generic;
using System.Linq;
using AquaTrack.Data.Models;
using AquaTrack.Repositories;

namespace AquaTrack.Services
{
    public class UserService
    {
        private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _repository.GetAll();
        }

        public User GetUserById(int id)
        {
            return _repository.GetById(id);
        }

        public void RegisterUser(User user)
        {
            _repository.Add(user);
        }

        public void UpdateUser(User user)
        {
            _repository.Update(user);
        }

        public void DeleteUser(int id)
        {
            _repository.Delete(id);
        }

        public User Authenticate(string email, string passwordHash)
        {
            return _repository
                .GetAll()
                .FirstOrDefault(u => u.Email == email && u.PasswordHash == passwordHash);
        }
    }
}
