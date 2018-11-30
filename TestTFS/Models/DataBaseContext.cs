﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TestTFS.Models
{
    public class DataBaseContext : DbContext

    {
        public DataBaseContext() : base("FirstProjectTFS") { }

        public DbSet<User> User { get; set; }

    }
}