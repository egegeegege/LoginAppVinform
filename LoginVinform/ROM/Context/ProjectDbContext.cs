using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginVinform.ROM.Entity;

namespace LoginVinform.ROM.Context
{
    internal class ProjectDbContext : DbContext
    {
        public ProjectDbContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=LogVinForm;uid=sa;pwd=1453";

        }
        // Migration steps
        // enable-migrations
        // add-migration 'a'
        // update-database
        public DbSet<UserItem> UserItems { get; set; }
        public DbSet<StaffItem> StaffItems { get; set; }
    }
}
