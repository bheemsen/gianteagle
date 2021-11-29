using Gianteagle.DAL.Repositories.IRepositories;
using Gianteagle.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gianteagle.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IRepository<User> repository;
        private readonly IUnitOfWorkRepository unitOfWorkRepository;
        public UserRepository(IRepository<User> _repository, IUnitOfWorkRepository workRepository)
        {
            this.repository = _repository;
            this.unitOfWorkRepository = workRepository;
        }

        public User AddUser(User user)
        {
            this.repository.Add(user);
            this.unitOfWorkRepository.SaveChanges();
            return user;
        }

        public User GetUser(int id)
        {
            return this.repository.Get(id);
        }

        public List<User> GetUsers()
        {
            return this.repository.Get();
        }
    }
}
