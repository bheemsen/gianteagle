using Gianteagle.BAL.IServices;
using Gianteagle.DAL.Repositories.IRepositories;
using Gianteagle.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gianteagle.BAL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository _userRepository)
        {
            this.userRepository = _userRepository;
        }

        public User AddUser(User user)
        {
            var dtoUser = new DTO.User()
            {
                CreatedDate = DateTime.Now,
                Email = "sam.ent",
                Name = "Sam"
            };
            dtoUser = this.userRepository.AddUser(dtoUser);
            user.UserId = dtoUser.UserId;
            return user;
        }

        public List<User> GetUsers()
        {
            return this.userRepository.GetUsers().Select(user => new User() { Email = user.Email, Name = user.Name, UserId = user.UserId }).ToList();
        }
    }
}
