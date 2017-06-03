using BNR.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNR.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
      //  private static readonly ILog log = LogManager.GetLogger(typeof(UnitOfWork));

        private readonly BNRContext _context;

        public UnitOfWork(BNRContext context)
        {
            _context = context;
            UserRepository = new UserRepository(_context);
        }

        public IUserRepository UserRepository { get; private set; }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
               // log.Error(ex);
                throw;
            }
        }

        public void Dispose()
        {
            try
            {
                _context.Dispose();
            }
            catch (Exception ex)
            {
              //  log.Error(ex);
                throw;
            }
        }

    }
}
