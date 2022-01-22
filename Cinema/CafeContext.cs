using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Cinema.Model;

namespace Cinema
{
    public class CafeContext : DbContext
    {
        public CafeContext() : base("DefaultConnection")
        {
        }
        public DbSet<Dop> Dops { get; set; }
    }
}
