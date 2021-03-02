using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Forum_Loco.Models
{
    public class UserContext : DbContext
    {

        public DbSet<User> userAcc { get; set; }

    }
}