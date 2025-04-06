using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Domain.Interface
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllUsers();

        public Task<User> GetUser(int id);

        public Task<User> CreateUser(User user);
    }
}
