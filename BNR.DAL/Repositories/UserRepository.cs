using BNR.DAL.Models;
using BNR.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNR.DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
       // private static readonly ILog log = LogManager.GetLogger(typeof(UserRepository));

        public UserRepository(BNRContext context) : base(context)
        {
        }

        public BNRContext BNRContext
        {
            get { return Context as BNRContext; }
        }


        public IEnumerable<User> GetAllUsersByRole(string role)
        {
            try
            {
                return BNRContext.Users.Where(x => x.Role == role).ToList();
            }
            catch (Exception ex)
            {
          //      log.Error(ex);
                throw;
            }
        }


    }
}
