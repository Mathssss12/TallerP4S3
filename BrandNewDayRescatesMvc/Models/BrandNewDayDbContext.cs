using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BrandNewDayRescatesMvc.Models
{
    public class BrandNewDayDbContext : DbContext
    {
        public BrandNewDayDbContext() : base("name=BrandNewDayDbContext") 
        {
        }

        public DbSet<Heroe> Heroes { get; set; }
        public DbSet<Rescate> Rescates { get; set; }
    }
}