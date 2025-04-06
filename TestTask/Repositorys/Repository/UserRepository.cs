using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Model;
using Storage;

namespace Repositorys
{
    public class UserRepository: IUserRepository
    {
        private readonly TestTaskContext _context;

        public UserRepository(TestTaskContext context) {
            _context = context;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var userEntities = await _context.Users
                .Include(u => u.Subdivision)
                .ToListAsync();

            return userEntities;
        }

        public async Task<User> GetUser(int id)
        {
            var userEntities = await _context.Users
                .Include(u => u.Subdivision)
                .ToListAsync();
            var user = userEntities
            .First(b => b.Id == id);

            return user;
        }

        public async Task<User> CreateUser(User user)
        {
            var _user = new User(
                user.Id,
                user.Name,
                user.SecondName,
                user.Fatherland,
                user.Job_title,
                user.SubdivisionId);

            return _user;
        }

    }
}
