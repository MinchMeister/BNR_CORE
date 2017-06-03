using BNR.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BNR.DAL.Repositories
{
    public class BNRContext : DbContext
    {
        public BNRContext() : base("db_a19aa3_bnrweb")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<User> Users { get; set; }
    }
}
