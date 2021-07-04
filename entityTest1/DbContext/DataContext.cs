using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace entityTest1
{
    public class DataContext : DbContext
    {
        public DataContext(string connectionString) : base(connectionString) 
        {
        }

        public DataContext() : base("yourconnectionstring")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<UserPermission> UserPermissions { get; set; }

    }
}