using System;
using System.Collections.Generic;
using System.Text;

namespace BNR.DAL.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }

        void Save();
    }
}
