using Gianteagle.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gianteagle.BAL.IServices
{
    public interface IUserService
    {
        List<User> GetUsers();

        User AddUser(User user);
    }
}
