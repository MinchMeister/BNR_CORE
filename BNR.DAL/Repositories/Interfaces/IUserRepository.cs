using BNR.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNR.DAL.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {


        IEnumerable<User> GetAllUsersByRole(string role);



    }
}
