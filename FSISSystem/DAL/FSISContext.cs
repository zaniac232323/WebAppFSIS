﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity; //inheritance of DbContext from EntityFramework
using FSISSystem.ENTITIES;

namespace FSISSystem.DAL
{
    internal class FSISContext : DbContext
    {
        public FSISContext() : base("FSIS_db")
        {

        }
        public DbSet<Gaurdian> Gaurdians { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
