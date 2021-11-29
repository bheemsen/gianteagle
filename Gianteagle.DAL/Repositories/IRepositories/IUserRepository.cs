using Gianteagle.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gianteagle.DAL.Repositories.IRepositories
{
    public interface IUserRepository 
    {
        User GetUser(int id);
        List<User> GetUsers();

        User AddUser(User user);
    }
}
